# 11586 지영 공주님의 마법 거울

n = int(input())
arr = [input() for _ in range(n)]
k = int(input())

if k == 1:
    for a in arr:
        print(a)
elif k == 2:
    for a in arr:
        print(a[::-1])
else:
    for i in range(len(arr) - 1, -1, -1):
        print(arr[i])
        