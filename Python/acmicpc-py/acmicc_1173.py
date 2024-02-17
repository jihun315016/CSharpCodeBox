# 1173 운동 

N, m, M, T, R = map(int, input().split())

if m + T > M:
    print(-1)
else:
    time = 0
    cur = m

    while N > 0:
        time = time + 1

        if cur + T <= M:
            cur = cur + T
            N = N - 1
        
        else:
            cur = cur - R
            if cur < m:
                cur = m

    print(time)
