# 17608 막대기

import sys
input = sys.stdin.readline

n = int(input())
arr = [int(input()) for _ in range(n)]
arr.reverse()

cur = 0
cnt = 0
for a in arr:
  if a > cur:
    cnt = cnt + 1
    cur = a
    
print(cnt)
