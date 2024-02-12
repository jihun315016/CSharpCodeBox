# 21866 추첨을 통해 커피를 받자

def check(arr, coffee):
    for i in range(len(arr)):
        if arr[i] > coffee[i]:
            return "hacker"
        
    if sum(arr) < 100:
       return "none"

    return "draw"

arr = list(map(int, input().split()))
coffee = [100, 100, 200, 200, 300, 300, 400, 400, 500]
print(check(arr, coffee))

