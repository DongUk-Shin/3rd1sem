#코드3.1 기본적인 매트릭스 만들기

x1 <- matrix(c(1,2,3,4), nrow=2, ncol=2)  # 매트릭스 x에 값 채우기(기본 값 : 열방향)
x1
z <- matrix(1:20, nrow=4, ncol=5)  # 매트릭스 z에 값 채우기(기본 값 : 열방향)
z                        
z1 <- matrix(1:20, nrow=4, ncol=5, byrow=F) #정식 문법
z1                               

#코드3.2 매트릭스에 저장될 값들을 행 방향으로 채우기
z2 <- matrix(1:20, nrow=4, ncol=5, byrow=T)  #행 방향으로 채우기 1부터 20
z2                               
z3 <- matrix(letters, nrow=2, ncol=13, byrow=T)  # 문자열에 대한 매트릭스도 가능함 letters
z3    
z3[1,1]

#코드3.3  매트릭스에 벡터를 추가하기
x <- 1:4                            # 벡터 x 생성
y <- 5:8                            # 벡터 y 생성
m1 <- cbind(x,y)                    # x와 y를 열 방향으로 결합하여 매트릭스 생성
m1                                  # 매트릭스 m1의 내용을 출력
m2 <- rbind(x,y)                    # x와 y를 행 방향으로 결합하여 매트릭스 생성
m2                                  # 매트릭스 m2의 내용을 출력
m3 <- rbind(m2,x)                   # 매트릭스 m2와 벡터 x를 행 방향으로 결합
m3                                  # 매트릭스 m3의 내용을 출력
m4 <- cbind(m1,x)                    # 매트릭스 z와 벡터 x를 열 방향으로 결합
m4                                  # 매트릭스 m4의 내용을 출력

#코드3.4 인덱스값을 이용하여 매트릭스에서의 값 추출하기

z <- matrix(1:20, nrow=4, ncol=5)   # 매트릭스 z 생성
z                                   # 매트릭스 z의 내용 출력
z[2,3]                              # 2행 3열에 있는 값
z[1,4]                              # 1행 4열에 있는 값
z[2,]                               # 2행에 있는 모든 값
z[,4]                               # 4열에 있는 모든 값

#코드3.5 매트릭스에서 여러 개의 값을 동시에 추출하기
z <- matrix(1:20, nrow=4, ncol=5)   # 매트릭스 z 생성
z                                   # 매트릭스 z의 내용 출력
z[2,1:3]                            # 2행의 값 중 1~3열에 있는 값
z[1,c(1,2,4)]                       # 1행의 값 중 1, 2, 4열에 있는 값
z[1:2,]                             # 1~2행에 있는 모든 값
z[,c(1,4)]                          # 1, 4열에 있는 모든 값

#코드3.6 매트릭스의 행과 열에 이름 지정
score <- matrix(c(90,85,69,78,
                  85,96,49,95,
                  90,80,70,60),
                nrow=4, ncol=3)
score
rownames(score) <- c('John','Tom','Mark','Jane')
colnames(score) <- c('English','Math','Science')
score

#코드3.7 행과 열에 지정한 이름을 이용하여 매트릭스값 추출하기
score['John','Math']                # John의 수학 성적
score['Tom',c('Math','Science')]    # Tom의 수학, 과학 성적
score['Mark',]                      # Mark의 모든 과목 성적
score[,'English']                   # 모든 학생의 영어 성적
rownames(score)                     # score의 행의 이름
colnames(score)                     # score의 열의 이름
colnames(score)[2]                  # score의 열의 이름 중 두 번째 값

#코드3.8 데이터프레임 만들기
city <- c("Seoul","Tokyo","Washington")   # 문자로 이루어진 벡터
rank <- c(1,3,2)                          # 숫자로 이루어진 벡터
city.info <- data.frame(city, rank)       # 데이터프레임 생성
city.info                                 # city.info의 내용 출력

#코드3.9 iris 데이터셋 (R에서 제공하는 실습용 데이터 예제)   
    # iris 150 그루의 붓꽃에 대해 4개 분야의 측정 데이터와 품종 정보를 결합
    # Sepal.Length  : 꽃받침의 길이
    # Sepal.Width   : 꽃받침의 너비 
    # Petal.Length  : 꽃잎의 길이
    # Petal.Width   : 꽃잎의 길이  
    # Species       : 붓꽃의 품종

iris
iris[,c(1:2)]                         # 1~2열의 모든 데이터
iris[,c(1,3,5)]                       # 1, 3, 5열의 모든 데이터
iris[,c("Sepal.Length","Species")]    # 1, 5열의 모든 데이터
iris[1:5,]                            # 1~5행의 모든 데이터
iris[1:5,c(1,3)]                      # 1~5행의 데이터 중 1, 3열의 데이터

#코드3.10 데이터셋의 기본 정보 확인
dim(iris)       # 행과 열의 개수 출력
nrow(iris)      # 행의 개수 출력
ncol(iris)      # 열의 개수 출력
colnames(iris)  # 열 이름 출력, names()와 결과 동일
head(iris)      # 데이터셋의 앞부분 일부 출력
tail(iris)      # 데이터셋의 뒷부분 일부 출력

#코드3.11  iris 데이터셋의 추가적인 내용 확인하기
str(iris)                 # 데이터셋 요약 정보 보기
iris[,5]                  # 품종 데이터 보기
unique(iris[,5])          # 품종의 종류 보기(중복 제거)
table(iris[,"Species"])   # 품종의 종류별 행의 개수 세기

#코드3.12 매트릭스와 데이터프레임에서 사용하는 함수
colSums(iris[,-5])    # 열별 합계 (-5는 5번째 열을 제외함을 의미)
colMeans(iris[,-5])   # 열별 평균
rowSums(iris[,-5])    # 행별 합계
rowMeans(iris[,-5])   # 행별 평균

#코드3.13 행과 열의 방향 전환 (전치행렬. Transpose)

z <- matrix(1:20, nrow=4, ncol=5)
z
t(z)                          # 행과 열 방향 전환

#코드3.14 조건에 맞는 행과 열의 값 추출
IR.1 <- subset(iris, Species=="setosa")
IR.1
IR.2 <- subset(iris, Sepal.Length>5.0 &
                 Sepal.Width>4.0)
IR.2
IR.2[, c(2,4)]                  # 2, 4열의 값만 추출

#코드3.15 매트릭스와 데이터프레임에 산술연산
a <- matrix(1:4,2,2)
b <- matrix(1:4,2,2)
a
b
t(a)
2*a                 # 매트릭스 a에 저장된 값들에 2를 곱하기
b-5
2*a + 3*b

a+b
b-a
b/a
a*b       #대응 성분끼리 곱
a%*%b     #행렬곱

#코드3.16  매트릭스와 데이터프레임의 자료구조 확인
class(a)
class(iris)             # iris 데이터셋의 자료구조 확인
class(state.x77)        # state.x77 데이터셋의 자료구조 확인
is.matrix(iris)         # 데이터셋이 매트릭스인지를 확인하는 함수
is.data.frame(iris)     # 데이터셋이 데이터프레임인지를 확인하는 함수
is.matrix(state.x77)
is.data.frame(state.x77)
is.matrix(a)
is.data.frame(a)

#코드3.17 매트릭스와 데이터프레임의 자료구조 변환
# 매트릭스를 데이터프레임으로 변환
state.x77  #미국 50개 주에 대한 통계데이터(인구, 소득, 문맹률, 기대수명 등)
st <- data.frame(state.x77)
head(st)
class(st)

# 데이터프레임을 매트릭스로 변환
iris.m <- as.matrix(iris[,1:4]) # 같은 자료형만 매트릭스로 변화 가능(5열제외)
head(iris.m)
class(iris.m)

#코드3.18  데이터프레임의 열 추출
iris[,"Species"]  # 결과=벡터. 매트릭스와 데이터프레임 모두 가능
iris[,5]          # 결과=벡터. 매트릭스와 데이터프레임 모두 가능
iris["Species"]   # 결과=데이터프레임. 데이터프레임만 가능
iris[5]           # 결과=데이터프레임. 데이터프레임만 가능
iris$Species      # 결과=벡터. 데이터프레임만 가능

#코드3.19 파일에서 데이터 읽어오기 (setwd함수 : set work directory,작업폴더 지정)
setwd("D:/source")                            # 작업 폴더 지정
air <- read.csv("airquality.csv", header=T)   # .csv 파일 읽기
air
class(air)             # air의 자료구조 확인
is.matrix(air)         # air가 매트릭스인지를 확인하는 함수
is.data.frame(air)     # air가 데이터프레임인지를 확인하는 함수

#코드3.20 파일에 데이터 쓰기
setwd("D:/source")                              # 작업 폴더 지정
my.iris <- subset(iris, Species=='setosa')      # setosa 품종 데이터만 추출
write.csv(my.iris, "my_iris.csv", row.names=F)  # .csv 파일에 저장하기

