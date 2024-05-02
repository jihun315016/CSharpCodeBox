# 8974 희주의 수학시험 

a, b = map(int, input().split())
arr = []

for i in range(1, b + 1):
    arr = arr + [i] * i

print(sum(arr[a - 1:b]))
