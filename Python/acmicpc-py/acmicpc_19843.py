# 19843 수면 패턴

import sys
input = sys.stdin.readline

dic = {
    "Mon" : 1,
    "Tue" : 2,
    "Wed" : 3,
    "Thu" : 4,
    "Fri" : 5
}

t, n = map(int, input().split())
total = 0

for _ in range(n):
    arr = input().split()
    
    time = int(arr[3]) - int(arr[1]) 
    if arr[0] != arr[2]:
        hour = time + 24
        dayTime = (dic[arr[2]] - dic[arr[0]] - 1) * 24
        time = hour + dayTime
    total = total + time

if total >= t:
    print(0)
elif total > 48:
    print(-1)
else:
    print(t - total)
