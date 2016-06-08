from datetime import datetime
import sys
import time

def add_gigasecond(start_date):    
    return  start_date.timetuple()
    
    
def main():
     print add_gigasecond(datetime(2011, 4, 25))

if __name__ == '__main__':
    sys.exit(int(main() or 0))