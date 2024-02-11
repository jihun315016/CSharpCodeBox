# 20124 모르고리즘 회장님 추천 받습니다

import sys
input = sys.stdin.readline

n = int(input())
arr = []

for _ in range(n):
    name, score = input().split()
    score = int(score)
    arr.append([name, score])

arr.sort(key = lambda x : (-x[1], x[0]))
print(arr[0][0])