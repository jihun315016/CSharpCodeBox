# 1350 진짜 공간

import math

n = int(input())
arr = list(map(int, input().split()))
k = int(input())

cnt = 0
for a in arr:
  cnt = cnt + math.ceil(a/k)

print(cnt * k)
