# 5575 타임 카드

arr = [list(map(int,input().split())) for _ in range(3)]

for a in arr:
    s = a[5] - a[2]
    if s < 0:
        a[4] = a[4] - 1
        s = s + 60
    
    m = a[4] - a[1]
    if m < 0:
        a[3] = a[3] - 1
        m = m + 60
    
    h = a[3] - a[0]

    print(h, m, s)
