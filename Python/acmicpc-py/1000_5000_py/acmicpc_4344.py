# 4344 평균은 넘겠지

import sys

input = sys.stdin.readline
t = int(input())
for _ in range(t):
    arr = list(map(int, input().split()))[1:]
    avg = sum(arr) / len(arr)
    k = 0
    
    for i in range(len(arr)):
        if arr[i] > avg:
            k = k + 1
    
    result = k / len(arr) * 100
    print("%.3f%%" % result)
