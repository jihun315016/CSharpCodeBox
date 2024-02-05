# 1712 손익분기점 

import math

a, b, c = map(int, input().split())
profit = c - b

if profit <= 0:
    print(-1)

elif a % profit == 0:
    print(a // profit + 1)
else:
    print(math.ceil(a / profit))
