# 2309 일곱 난쟁이 

def find(arr, total):
    for i in range(len(arr)):
        for j in range(i + 1, len(arr)):
            if arr[i] + arr[j] == total:
                return arr[i], arr[j]

arr = [int(input()) for _ in range(9)]
total = sum(arr) - 100 
target = find(arr, total)

arr.remove(target[0])
arr.remove(target[1])

for a in sorted(arr):
    print(a)
