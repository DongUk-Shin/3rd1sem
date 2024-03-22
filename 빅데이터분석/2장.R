#코드2.1 (산술 연산자)
2+3
2+3.0     # 정수, 실수  따로 구분하지 않음
(3+6)*8
2^3            #2의 세제곱
2.5^3         # 2.5의 세제곱
2/3
8%%3            # 8/3의 나머지


#코드2.3 (산술 연산함수)
log(10)     # 로그함수(자연로그)
log(10, base=exp(1)) # 윗식과 같은 의미

log(10, base=10)     # 상용로그
sqrt(25)       # 제곱근
25^(1/2)
8^(1/3)        # 세제곱근
max(5,3,2)     # 가장 큰 값

round (1.6)   #(소수점 반올림)
trunc (1.6)   #(소수점 버림)

#내장상수
pi      # 파이
exp(1)  # e 의 제곱
LETTERS
letters
month.abb
month.name
day.abb

# b = 20 이와같은 할당 연산자는 권장하지 않음 ( 비교 연산에 사용되기에 )


#코드2.4  
a <- 10
b <- 20           
c <- a+b
print(c) 

#코드2.5 (변수에 저장된 값 확인하기)
a <- 125 
a          
print(a)

# 변수에 입력하는 두가지 방법
a <- 10     # a에 숫자 저장
a
a=10        # a에 숫자 저장(권장하지 않음)
a

#코드2.6 (변수의 값 변경)
a <- 10
b <- 20
a+b         # a+b의 결과 출력
a <- "A"    # a에 문자 저장
a+b         # a+b의 결과 출력. 에러 발생

#코드2.7 (벡터 만들기)
x <- c(1,2,3)                   # 숫자형 벡터. c는 combine의 약자
y <- c("a","b","c")             # 문자형 벡터
z <- c(TRUE,TRUE, FALSE, TRUE)  # 논리형 벡터
w=c(x,y)                        #벡터의 결합
x                               # x에 저장된 값을 출력
y
z
w   #숫자와 문자의 결합 시 결과에 주목하자!!


#코드2.9(연속적인 숫자 생성)
v1 <- 50:90 
v1
v2 <- c(1,2,5, 50:90)  
v2

#코드2.10  (일정한 간격, 즉, 등차수열)

v3 <- seq(1, 101,3)
v3
v4 <- seq(0.1, 1.0, 0.1)  
v4

#코드2.11 (숫자의 반복)
v5 <- rep(1,times=5)            # 1을 5번 반복
v5
v6 <- rep(1:5,times=3)          # 1에서 5까지 3번 반복
v6
v7 <- rep(c(1,5,9), times=3)    # 1, 5, 9를 3번 반복
v7
v8 <- rep(c(1,5,9), each=3)     # 1, 5, 9를 각각 3번 반복
v8

#코드2.12 (벡터의 원소값에 이름 지정)
score <- c(90,85,70)                    # 성적
score
names(score)                            # score에 저장된 값들의 이름을 보이시오
names(score) <- c("John","Tom","Jane")  # 값들에 이름을 부여
names(score)                            # score에 저장된 값들의 이름을 보이시오
score                                   # 이름과 함께 값이 출력   

#코드2.13 (벡터에서 원소값 추출)
d <- c(1,4,3,7,8)
d[1]
d[2]
d[3]
d[4]
d[5]
d[6]

#코드2.14 (벡터에서 여러 개의 값을 한 번에 추출하기)
d <- c(1,4,3,7,8)
d[c(1,3,5)]             # 1, 3, 5번째 값 출력
d[1:3]                  # 처음 세 개의 값 출력
d[seq(1,5,2)]           # 홀수 번째 값 출력
d[-2]                   # 2번째 값 제외하고 출력
d[-c(3:5)]              # 3~5번째 값은 제외하고 출력

#코드2.15 (벡터에서 이름으로 값을 추출하기)
GNP <- c(2090,2450,960)
GNP
names(GNP) <- c("Korea","Japan","Nepal")
GNP
GNP[1]
GNP["Korea"]
GNP[c("Korea","Nepal")]

#코드2.16 (벡터에 저장된 원소값 변경)
v1 <- c(1,5,7,8,9)
v1
v1[2] <- 3              # v1의 2번째 값을 3으로 변경
v1
v1[c(1,5)] <- c(10,20)  # v1의 1, 5번째 값을 각각 10, 20으로 변경
v1

#코드2.17 (벡터와 스칼라값 연산)
d <- c(1,4,3,7,8)
2*d 
d-5
3*d+4 

#코드2.18 (벡터와 벡터 간의 연산)
x <- c(1,2,3)
y <- c(4,5,6)
x+y               # 대응하는 원소끼리 더하여 출력
x*y               # 대응하는 원소끼리 곱하여 출력
z <- x + y        # x, y를 더하여 z에 저장
z

#코드2.19 (벡터에 대한 함수)
d <- c(1,2,3,4,5,6,7,8,9,10)
sum(d)                          # d에 포함된 값들의 합
sum(2*d)                        # d에 포함된 값들에 2를 곱한 후 합한 값
length(d)                       # d에 포함된 값들의 개수
mean(d)                         # d에 포함된 값들의 평균
mean(d[1:5])                    # 1~5번째 값들의 평균
max(d)                          # d에 포함된 값들의 최댓값
min(d)                          # d에 포함된 값들의 최솟값
sort(d)                         # 오름차순 정렬
sort(d, decreasing = FALSE)     # 오름차순 정렬
sort(d, decreasing = TRUE)      # 내림차순 정렬
v1 <- median(d)
v1
v2 <- sum(d)/length(d)
v2

# 함수와 매개변수(PARAMETER)
# 1.명시적(Explicit) 방법
sort(x=d,decreasing = TRUE)  #매개변수명과 매개변수 값을 쌍으로 연결
sort(x=d,decreasing = FALSE)

# 2.암시적(Explicit) 방법 (매개변수명을 생략 가능. 그러나 순서와 형식이 맞아야 함)
sort(d,decreasing = FALSE)
sort(d, FALSE)
sort(FALSE, d)  # 해당 매개변수와 입력 값이 불일치. 에러 발생

# 3. 초기값(default value)은 생략이 가능 (예 : decreasing = FALSE)
sort(d)


#코드2.20 (벡터에 논리연산자 적용)
d <- c(1,2,3,4,5,6,7,8,9)
d>=5
d[d>5]                    # 5보다 큰 값
d==5
condi <- d > 5 & d < 8    # 조건을 변수에 저장
d[condi]                  # 조건에 맞는 값들을 선택

sum(d>5)                  # 5보다 큰 값의 개수를 출력
sum(d[d>5])               # 5보다 큰 값의 합계를 출력

#코드2.21 (리스트의 입력과 출력)
ds <- c(90, 85, 70, 84)
my.info <- list(name='Tom', age=60, status=TRUE, score=ds)
my.info                 # 리스트에 저장된 내용을 모두 출력
my.info[[1]]            # 리스트의 첫 번째 값(name)을 출력
my.info$name            # 리스트에서 값의 이름이 name인 값을 출력
my.info[[4]]            # 리스트의 네 번째 값(score)을 출력
my.info$score           # 리스트에서 값의 이름이 score인 값을 출력


#코드2.22 (팩터의 입력과 출력)
bt <- c('A', 'B', 'B', 'O', 'AB', 'A')     # 문자형 벡터 bt(blood type) 정의
bt
bt_factor <- factor(bt)                    # 팩터 bt.new 정의
bt                                         # 벡터 bt의 내용 출력
bt_factor                                  # 팩터 bt.new의 내용 출력
bt[5]                                      # 벡터 bt의 5번째 값 출력
bt_factor[5]                               # 팩터 bt.new의 5번째 값 출력
levels(bt_factor)                          # 팩터에 저장된 값의 종류를 출력
as.integer(bt_factor)                      # 팩터의 문자값을 숫자로 바꾸어 출력
bt_factor[7] <- 'B'                        # 팩터 bt.new의 7번째에 'B' 저장
bt_factor[8] <- 'C'                        # 팩터 bt.new의 8번째에 'C' 저장
bt_factor                                  # 팩터 bt.new의 내용 출력

levels(bt_factor) <- c(levels(bt_factor), 'C') # 팩터 bt.new의level에 'C'추가
bt_factor[8] <- 'C'                        # 팩터 bt.new의 8번째에 'C' 저장
bt_factor     
