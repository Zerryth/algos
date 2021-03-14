import sys
from collections import namedtuple

'''
Find the minimum number of points needed to cover all given segnments on a line.

Input: A sequence of n segments (L1, R1), ..., (Ln, Rn) on a line
    - n number of segments
    - following n lines contain the segments with 2 integers (Li, Ri)

Output: A set of points of minimum size such that each segment (Li, Ri) contains a point,
i.e. there exists a point x such that Li <= x <= Ri
    - The minimum number of k points on the first line
    - And the integer coordinates on the 2nd line
    - Can output the points in any order
    - If there are many sets, can output any set

Constraints: 1 <= n <= 100, 0 <= Li <= Ri <= 10 ** 9

Sample:
    Input:
        3
        1 3 - compare seg[0] for each and see which is smaller
        2 5 - check if coordinate seg[1]Smaller >= seg[1]Bigger => if yes, they overlap --> maybe store overlapping coords in a sep. set? ()
        3 6
    Output:
        1
        3
    All three segments (1, 3), (2, 5), and (3, 6) contain point with coordinate 3

    Input:
        4
        4 7
        1 3 
        2 5
        5 6
    Output:
        2
        3 6
        The 2nd and 3rd segments (4, 7) and (1, 3) contain point with coordinate 3,
        while the 1st and 4th segments contain point with coordinate 6.

        Not all segments can be covered by a single point, since segments (5, 6) and (1, 3) don't overlap
'''
Segment = namedtuple('Segment', 'start end')

def covers_common_coordinate(segment, coordinate):
    return segment.start <= coordinate

def optimal_points(segments):
    segments.sort(key=lambda s: s.end)
    points = []

    while(len(segments)):
        smallest_right_end = segments.pop(0).end
        points.append(smallest_right_end)

        while (len(segments)):
            if (covers_common_coordinate(segments[0], smallest_right_end)):
                segments.remove(segments[0])
            else:
                break


    return points

if __name__ == '__main__':
    input = sys.stdin.read()
    n, *data = map(int, input.split()) # n: 4, *data: [4, 7, 1, 3, 2, 5, 5, 6]
    # n, *data = map(int, ['4', '4', '7', '1', '3', '2', '5', '5', '6'])
    # n, *data = map(int, ['3', '1', '3', '2', '5', '3', '6'])
    # [Segment(start=4, end=7), Segment(start=1, end=3), Segment(start=2, end=5), Segment(start=5, end=6)]
    segments = list(map(lambda x: Segment(x[0], x[1]), zip(data[::2], data[1::2])))
    points = optimal_points(segments)
    print(len(points))
    print(*points)
