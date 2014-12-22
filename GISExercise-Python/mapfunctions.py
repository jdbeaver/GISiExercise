__author__ = 'jbeaver'

import math

class MapFunctions():

    # normalize a longitude that falls outside of range(-180,180) e.g: -220
    def norm_longitude_mod(self, lon_value):
        # determine modulus of given longitude value when divided by 360 degrees
        lon_mod = lon_value % 360
        # handle the cases where value is greater than 180 degrees and smaller than -180 degrees
        if lon_mod > 180:
            diff = lon_mod - 180
            lon_mod = -180 + diff
        elif lon_mod < -180:
            diff = lon_mod + 180
            lon_mod = 180 + diff
        return lon_mod