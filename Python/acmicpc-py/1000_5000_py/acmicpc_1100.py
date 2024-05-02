# 1100 하얀 칸

arr = [input() for _ in range(8)]
cnt = 0

for i in range(8):
    if i % 2 == 0:
        start = 0
    else:
        start = 1

    for j in range(start, 8, 2):
        if arr[i][j] == 'F':
            cnt = cnt + 1

print(cnt)
