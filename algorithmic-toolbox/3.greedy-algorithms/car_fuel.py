# python3
import sys

class Car:
    def __init__(self, distance, tank, stops):
        self.total_distance_to_city = distance
        self.full_tank = tank
        self.fuel_remaining = tank
        self.stops = stops
        self.refills_count = 0
        self.current_location = -1
    
    def calculate_min_refuels(self):
        if (self.fuel_remaining > self.total_distance_to_city):
            return self.refills_count
        
        while(True):
            if (self.can_get_to_city()):
                return self.refills_count
            
            if (not self.is_valid_stop(self.current_location + 1)):
                return -1
            
            if (self.can_get_to_next_stop()):
                self.drive()
            else:
                self.refuel()

                if (self.can_get_to_city()):
                    return self.refills_count

                if (self.can_get_to_next_stop()):
                    self.drive()
                    continue
                
                return -1

        # return -1
    
    def can_get_to_city(self):
        current_location = 0 if self.is_at_starting_city() else self.stops[self.current_location]
        distance = self.total_distance_to_city - current_location
        
        if (distance <= self.fuel_remaining):
            return True

        if (distance <= self.full_tank):
            self.refuel()
            return True
        
        return False
    
    def can_get_to_next_stop(self):
        dist = self.get_distance_to_next_stop()
        return self.get_distance_to_next_stop() <= self.fuel_remaining
    
    def drive(self):
        dist = self.get_distance_to_next_stop()
        self.fuel_remaining -= self.get_distance_to_next_stop()
        self.current_location += 1
    
    def refuel(self):
        self.fuel_remaining = self.full_tank
        self.refills_count += 1
        
    def is_at_starting_city(self):
        return self.current_location == -1
    
    def is_valid_stop(self, stop):
        return stop < len(self.stops)
    
    def get_distance_to_next_stop(self):
        current_distance = stops[self.current_location] if self.current_location != -1 else 0
        next_location = self.current_location + 1

        if (next_location >= len(stops)):
            return False

        return stops[next_location] - current_distance


if __name__ == '__main__':
    # test_input = [d, tank, stops, stop1, stop2, stop3, stop4]
    # test_input = ['950', '400', '4', '200', '375', '550', '750'] # 2
    # test_input = ['10', '3', '4', '1', '2', '5', '9'] # -1
    # test_input = ['10', '3', '2', '5', '9'] # -1
    test_input = ['200', '250', '2', '100', '150'] # 0
    # test_input = ['500', '200', '4', '100', '200', '300', '400']
    # test_input = ['700', '200', '4', '100', '200', '300', '400']
    # test_input = ['10', '3', '4', '1', '2', '5', '9'] # -1
    # test_input = ['200', '250', '2', '100', '150'] # 0
    # test_input = ['1200', '400', '4', '200', '375', '550', '750'] # -1
    # test_input = ['1150', '400', '4', '200', '375', '550', '750'] # 2
    # test_input = ['0', '400', '0'] # 2
    # test_input = ['400', '250', '2', '100', '150'] # 1
    # test_input = ['400', '250', '2', '100', '150'] #output 1
    # test_input = [1000, 200, '100', '200', '7', '250', '300', '400', '600', '780'] #-1
    # test_input = ['1000', '200', '8', '100', '200', '250', '300', '400', '600', '780', '820'] #5
# compute_min_refills(1000, 200, [100, 200,250, 300, 400, 600,820]) #-1
# compute_min_refills(1000, 200, [100, 200,250, 300, 400, 600,800]) #4
# compute_min_refills(10,3, [1,2,5,9]) #-1
# compute_min_refills(200,250,[100,150]) #0
# compute_min_refills(1200, 400, [200, 375, 550, 750]) #-1
# compute_min_refills(1150, 400, [200, 375, 550, 750]) #2
# compute_min_refills(200, 250, [100, 150]) #0
# compute_min_refills( 10, 3, [1, 2, 5, 9]) #-1
    # test_input = ['750', '400', '3', '200', '375', '550'] # 2
    # (10,3, [1,2,5,9])
    d, m, _, *stops = map(int, sys.stdin.read().split())
    # d, m, _, *stops = map(int, test_input)
    mycar = Car(d, m, stops)
    print(mycar.calculate_min_refuels(d, m, stops))
    # print(compute_min_refills(d, m, stops))
