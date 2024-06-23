# 연습문제 > 과제 진행하기

class Homework:
    def __init__(self, plan):
        self.name = plan[0]
        time = list(map(int, plan[1].split(":")))
        self.start = time[0] * 60 + time[1] # 시간을 분으로 표현
        self.time = int(plan[2])


def solution(plans):
    answer = []
    stack = []
    curTime = 0
    plans.sort(key=lambda x : x[1])

    for p in plans:
        homework = Homework(p)
        if not stack:
            stack.append(homework)
        else:
            if stack[-1].start + stack[-1].time > homework.start:
                # 과제 진행 중 새로운 과제가 생김
                diff = homework.start - curTime
                stack[-1].time = stack[-1].time - diff # 진행 중이던 과제니까 걸리는 시간(time) 조정
                stack.append(stack.pop())
                stack.append(homework)
            else:
                # 진행 중인 과제를 끝까지 할 수 있음
                # 과제가 시작하기 전까지 남은 시간동안 밀린 과제 처리
                curTime = stack[-1].start + stack[-1].time
                remaining = homework.start - curTime
                answer.append(stack.pop().name)
                while stack and remaining > 0:
                    if stack[-1].time > remaining:
                        stack[-1].time = stack[-1].time - remaining
                        break
                    else:
                        temp = stack.pop()
                        remaining = remaining - temp.time
                        answer.append(temp.name)

                stack.append(homework)
        curTime = homework.start
            
    # 진행 중인 과제 처리
    # 멈춰둔 과제가 여러 개일 경우, 가장 최근에 멈춘 과제부터 시작하므로 역순으로 출력
    onGoing = list(reversed([h.name for h in stack]))
    return answer + onGoing


plan = [["korean", "11:40", "30"], ["english", "12:10", "20"], ["math", "12:30", "40"]]
print(solution(plan))

plan = [["science", "12:40", "50"], ["music", "12:20", "40"], ["history", "14:00", "30"], ["computer", "12:30", "100"]]
print(solution(plan))

plan = [["aaa", "12:00", "20"], ["bbb", "12:10", "30"], ["ccc", "12:40", "10"]]
print(solution(plan))

plan = [["aaa", "12:00", "20"], ["bbb", "12:10", "30"], ["ccc", "13:40", "10"], ["ddd", "12:50", "10"]]
print(solution(plan))
