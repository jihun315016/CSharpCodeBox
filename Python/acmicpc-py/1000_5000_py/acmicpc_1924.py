# 1924 2007년

x, y = map(int, input().split())
days = 0
arr = ["MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN"]

for i in range(1, x):
    if i in (1, 3, 5, 7, 8, 10, 12):
        days = days + 31
    elif i in (4, 6, 9, 11):
        days = days + 30
    else:
        days = days + 28

days = days + y - 1
print(arr[days % 7])
