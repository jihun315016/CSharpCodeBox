# 2953 나는 요리사다

arr = [sum(list(map(int, input().split()))) for _ in range(5)]

iMax = max(arr)
iLoc = arr.index(iMax) + 1

print(iLoc, iMax)
