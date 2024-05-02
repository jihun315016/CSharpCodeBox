# 5532 방학 숙제

import math

arr = [int(input()) for _ in range(5)]
mDay = math.ceil(arr[2] / arr[4])
kDay = math.ceil(arr[1] / arr[3])

print(min(arr[0] - mDay, arr[0] - kDay))
