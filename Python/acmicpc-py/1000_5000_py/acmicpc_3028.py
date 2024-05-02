# 3028 창영마을

sInput = input()
arr = [1, 0, 0]

for s in sInput:
    if s == 'A':
        arr[0], arr[1] = arr[1], arr[0]
    elif s == 'B':
        arr[1], arr[2] = arr[2], arr[1]
    else:
        arr[0], arr[2] = arr[2], arr[0]

print(arr.index(1) + 1)
