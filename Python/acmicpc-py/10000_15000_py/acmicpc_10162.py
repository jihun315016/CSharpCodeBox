# 10162 전자레인지

t = int(input())

arr = [300, 60, 10]
cnt = [0, 0, 0]

for i in range(len(arr)):
    cnt[i] = cnt[i] + t // arr[i]
    t = t % arr[i]
    
if t == 0:
    print(" ".join(list(map(str, cnt))))
else:
    print(-1)