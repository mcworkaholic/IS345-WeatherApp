import sys

# Array used for regionalization #
# west = ["CA", "OR", "WA", "NV", "ID", "UT", "CO", "WY", "MT"]
# midwest = ["ND", "SD", "NE", "KS", "MN", "IA", "MO", "WI", "IL", "IN", "MI", "OH"]
# southwest = ["AZ", "NM", "TX", "OK"]
# southeast = ["AR", "LA", "MS", "TN", "AL", "KY", "GA", "WV", "VA", "NC", "SC", "FL", "MD", "DE"]
# northeast = ["CT", "DC", "HI", "ME", "MA", "NH", "NJ", "NY", "PA", "RI", "VT"]
# noncontig = ["HI", "AK"]

if __name__ == '__main__':
    if len(sys.argv) < 2:
        print("Please provide a filename as an argument.")
    else:
        filename = sys.argv[1]
        print(filename)

