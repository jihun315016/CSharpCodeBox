# 연습문제 > 가장 가까운 같은 글자

def solution(s):
    answer = []
    dic = {}

    for i in range(len(s)):
        if s[i] in dic:
            # 현재 인덱스와 최근에 나온 s[i] 문자의 거리 차이
            diff = i - dic[s[i]] 
            answer.append(diff)
        else:
            answer.append(-1)
        dic[s[i]] = i

    return answer

s = "banana"
print(solution(s))

s = "foobar"
print(solution(s))
