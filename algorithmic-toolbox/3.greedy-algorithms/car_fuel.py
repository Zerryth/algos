# python3
import sys


# def compute_min_refills(distance, tank, stops):

#     return -1

# if __name__ == '__main__':
#     test_input = ['950', '400', '4', '200', '375', '550', '750']
#     d, m, _, *stops = map(int, test_input)
#     # d, m, _, *stops = map(int, sys.stdin.read().split())
#     print(compute_min_refills(d, m, stops))

def can_get_to_next_location_without_refill(fuel_remaining, d, stops, current_location, next_location):
    # 1st time around current_location should be 0
    # ['200'] (length = 1)
    # ['200', '375', '550', '750']
    #    0     1       2      3
    #                       curr
    #                       next_loc
    #                p_next

    # m=25

    distance_to_next_stop = 0
    distance_to_city = d - stops[current_location] # 950 - 
    potential_next_stop = next_location if next_location != current_location else current_location + 1 # p_next = 2

    if (distance_to_city <= fuel_remaining):
        # We can get to the city without any additional stops,
        # so we'll set potential_next stop value to -1
        return (True, distance_to_city, -1)

    if (potential_next_stop >= len(stops) and distance_to_city > fuel_remaining):
        # there are no remaining stops, nor can we reach the city
        return (False, distance_to_next_stop, potential_next_stop) # it might be breaking here?
    
    # dist_to_next_stop = 550 - 375 => 175
    distance_to_next_stop = stops[potential_next_stop] - stops[current_location]

    if (distance_to_next_stop > fuel_remaining):
        # 175 > 25
        # False, 2, 2
        return (False, distance_to_next_stop, potential_next_stop) # maybe return something else for dist to next and potential next for this case, since we can't get to next stop?

    return (True, distance_to_next_stop, potential_next_stop)

def compute_min_refills(distance, tank, stops):
    refills_count = 0

    if (tank > distance):
        return refills_count
    
    if (len(stops) == 0):
        return -1
    
    current_location = -1
    fuel_remaining = tank
    next_location = 0
    

    # ['200', '375', '550', '750']
    #    0     1       2      3
    #                        curr 
    #                        next                           
    #   m=400
    # refills= 1

    while(distance): # hmm, this is always 950...is this the right condition?
        current_distance = stops[current_location] if current_location != -1 else -1
        next_location = current_location + 1 if current_location + 1 < len(stops) else -1 # it's -1 at the end

        if (next_location == -1):
            if (distance - current_distance > fuel_remaining):
                return -1

            return refills_count
        
        # next_distance = 550 - 375 => 175
        next_distance = stops[next_location] - current_distance if current_distance != -1 else stops[next_location]

        if (tank < next_distance):
            return -1
        
        current_location = next_location # next_location = current_location + 1 after this??
        fuel_remaining -= next_distance

        can_drive_to_next, distance_to_next_location, next_loc = can_get_to_next_location_without_refill(fuel_remaining, distance, stops, current_location, next_location)
        while(can_drive_to_next):
            current_location = next_loc
            next_location += (next_loc + 1) # should change to curr + 1 ?
            fuel_remaining -= distance_to_next_location
            
            # fuel_remaining = 25, current_location = 1, next_location = 2
            next_location_data = can_get_to_next_location_without_refill(fuel_remaining, distance, stops, current_location, next_location) 
            # next_location_data => (False, 2, 2)
            # (True, <distance_to_city>, -1)
            # (True, <distance_to_next_stop>, )
            can_drive_to_next = next_location_data[0]
            if (can_drive_to_next):
                can_drive_to_city = next_location_data[2] == -1
                if (can_drive_to_city):
                    return refills_count
                
                next_location = next_location_data[2]

        refills_count += 1
        fuel_remaining = tank

    return -1

if __name__ == '__main__':
    # test_input = [d, tank, stops, stop1, stop2, stop3, stop4]
    # test_input = ['950', '400', '4', '200', '375', '550', '750']
    # test_input = ['10', '3', '4', '1', '2', '5', '9']
    # test_input = ['200', '250', '2', '100', '150']
    # test_input = ['500', '200', '4', '100', '200', '300', '400']
    # test_input = ['700', '200', '4', '100', '200', '300', '400']
    d, m, _, *stops = map(int, sys.stdin.read().split())
    # d, m, _, *stops = map(int, test_input)
    print(compute_min_refills(d, m, stops))
