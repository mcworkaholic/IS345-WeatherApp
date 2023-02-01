import sys
import os
import pandas as pd
import matplotlib.pyplot as plt
import sqlite3


"""
This script is designed to plot a multiple time series of average monthly maximum temperature by region. 
It takes in three command line arguments: the filename of the SQLite3 database, the begin year and end year to query the data.
The script first connects to the SQLite3 database using the provided filename and queries the data using the provided begin year and end year as parameters. 
The data is then read into a Pandas DataFrame and preprocessed to ensure that it is in the correct format for plotting.
The script then uses the Matplotlib library to create a multiple time series plot of the data, with each region represented by a different line. The plot is saved to the 'img' directory with the name 'plot.png'

"""

def plot(filename, begin_year, end_year):
   
    con = sqlite3.connect(filename)
    sql = """SELECT region, date, year, month, temp, AVG(temp) FROM weather WHERE year >= ? AND year <= ? GROUP BY region, year, month"""

    # Read the data from the local database into a Pandas DataFrame with the commandline arguments
    data = pd.read_sql_query(sql, con, params=[begin_year, end_year])
    data['date'] = pd.to_datetime(data['date'], format='%m/%d/%Y')
    data['temp'] = pd.to_numeric(data['temp'], errors='coerce')
    data = data.set_index('date')
    data = data.sort_index()
    data = data.interpolate()
    
    path = os.path.dirname(os.path.dirname( __file__ ))
    #print(path)
    
    try:
        os.remove(path + "\\img\\plot.png")
    except OSError:
        pass
    
    # Create the multiple time series plot
    plt.figure(figsize=(17, 8))
    
    for region in data.region.unique():
        region_data = data[data.region==region]
        try:
            plt.plot(region_data.index, region_data.temp, label=region)
        except ValueError:
            pass
    #print(region_data)
    
    plt.title("Monthly Max Temperature By Region")
    plt.xlabel('Year')
    plt.ylabel('Monthly Max Temperature')
    plt.legend(bbox_to_anchor=(1.01, -0.10), loc='lower right')
    plt.tight_layout()
    plt.savefig(path + "\\img\\plot.png")
    plt.close()


if __name__ == '__main__':
    if len(sys.argv) < 2:
        print("Please provide a filename as an argument.")
    else:
        filename = sys.argv[1]
        begin_year = sys.argv[2]
        end_year = sys.argv[3]
        plot(filename, begin_year, end_year)

