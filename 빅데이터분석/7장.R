#결측값이란?
head(airquality)

#7-1 결측값의 특성과 존재 여부 확인

z <- c(1,2,3,NA,5,NA,8)    # 결측값이 포함된 벡터 z
sum(z)                     # 정상 계산이 안 됨
is.na(z)                   # NA 여부 확인
sum(is.na(z))              # NA의 개수 확인
sum(z, na.rm=TRUE)         # NA를 제외하고 합계를 계산 (na.rm NA를 remove할지 여부)

#7-2 결측값 대체 및 제거
z1 <- c(1,2,3,NA,5,NA,8)     # 결측값이 포함된 벡터 z1
z2 <- c(5,8,1,NA,3,NA,7)     # 결측값이 포함된 벡터 z2
z1[is.na(z1)] <- 0           # NA를 0으로 치환
z1
z3 <- as.vector(na.omit(z2)) # NA를 제거하고 새로운 벡터 생성
z3
z4 <- na.omit(z2) # NA를 제거하고 새로운 벡터 생성
z4

#매트릭스와 데이터프레임의 결측값 처리

#7-3  결측값이 포함된 데이터프레임 생성


# NA를 포함하는 test 데이터 생성해보자
x <- iris
x[1,2]<- NA; x[1,3]<- NA
x[2,3]<- NA; x[3,4]<- NA  
head(x)

#7-4 데이터프레임의 열별 결측값 확인

sum(is.na(x))
colSums(is.na(x))

# for문을 이용한 방법
# for (i in 1:ncol(x)) {
#   temp <- is.na(x[,i]) 
#   cat(colnames(x)[i], "\t", sum(temp), "\n") # cat(문자열 합치기), \t(탭), \n(줄바꾸기)
# }

# apply를 이용한 방법
# col_na <- function(y) {
#   return(sum(is.na(y)))
# }
# na_count <-apply(x, 2, FUN=col_na)
# na_count



#7-5 데이터프레임의 행별 결측값 확인

rowSums(is.na(x))         # 행별 NA의 개수
sum(rowSums(is.na(x))>0)  # NA가 포함된 행의 개수

sum(is.na(x))             # 데이터셋 전체에서 NA 개수


#7-6 결측값을 제외하고 새로운 데이터셋 만들기
head(x)
x[!complete.cases(x),]         # NA가 포함된 행들 출력
y1 <- x[complete.cases(x),]    # NA가 포함된 행들 제거
head(y1)                       # 새로운 데이터셋 y의 내용 확인

y2 <- na.omit(x)               # na.omit(x)함수를 쓰면 보다 간단   
head(y2)

#7-7 상자그림을 통한 특이값 확인
st <- data.frame(state.x77)
boxplot(st$Income)
boxplot.stats(st$Income)$out


#7-8  특이값을 포함한 행 제거(NA로 대체 후 제거)

out.val <- boxplot.stats(st$Income)$out    # 특이값 추출
st$Income[st$Income %in% out.val] <- NA    # 특이값을 NA로 대체. %in% 연산자는 벡터내 특정 값 포함여부 확인
head(st)
#newdata <- st[complete.cases(st),]         # NA가 포함된 행 제거
newdata <- na.omit(st)                      # NA가 포함된 행 제거
head(newdata)



#7-9 벡터의 정렬  
v1 <- c(1,7,6,8,4,2,3)
order(v1)                       # 데이터이 크기 순위
v1[order(v1)]                   # 데이터이 크기 순서대로 출력
v2 <- sort(v1)                  # 오름차순
v2
v3 <- sort(v1, decreasing=T)    # 내림차순 
v3

#7-10  매트릭스와 데이터프레임의 정렬

head(iris)
order(iris$Sepal.Length)
iris[order(iris$Sepal.Length),]                        # 오름차순으로 정렬
iris[order(iris$Sepal.Length, decreasing=T),]          # 내림차순으로 정렬
iris.new <- iris[order(iris$Sepal.Length),]            # 정렬된 데이터를 저장
head(iris.new)
iris[order(iris$Species, -iris$Petal.Length, decreasing=T),]   # 정렬 기준이 2개

#매트릭스와 데이터프레임의 정렬에서는 sort를 사용할 수 없다
# 그러나 plyr 패키지의 arrange() 함수를 사용해서 정렬할 수 있음
library(plyr)
arrange(iris, iris$Sepal.Length)
arrange(iris, desc(iris$Sepal.Length))

#7-11 데이터 분리
sp <- split(iris, iris$Species)   # 품종별로 데이터 분리
sp                                # 분리 결과 확인
summary(sp)                       # 분리 결과 요약
sp$setosa                         # setosa 품종의 데이터 확인


#7-12 데이터 선택
subset(iris, Species == "setosa")
subset(iris, Sepal.Length > 7.5)
subset(iris, Sepal.Length > 5.1 & 
         Sepal.Width > 3.9)

subset(iris, Sepal.Length > 7.6,
       select=c(Petal.Length,Petal.Width))


#7-13  숫자를 임의로 추출하기

x <- 1:100
y <- sample(x, size=10, replace = FALSE)  # 비복원추출
y


#7-14 행을 임의로 추출하기- 데이터셋에서 n개의 행을 임의로 추출

idx <- sample(1:nrow(iris), size=50,
              replace = FALSE)
iris.50 <- iris[idx,]               # 50개의 행 추출
dim(iris.50)                        # 행과 열의 개수 확인
head(iris.50)

#7-15 set.seed( ) 함수 - 다음 번 추출에서도 같은 결과가 나오도록 함

sample(1:20, size=5)
sample(1:20, size=5)
sample(1:20, size=5)

set.seed(100)          #set.seed() 함수의 매개변수 값이 같으면 sample() 함수의 결과도 같다
sample(1:20, size=5)
set.seed(100)       
sample(1:20, size=5)
set.seed(100)
sample(1:20, size=5)

# 참고 (시뮬레이션을 위한 난수 발생)

# 균등분표 난수 발생 runif(n) [0,1] 사이의 난수를 n개 생성
runif(10)

# [0,m] 사이의 균등분표 난수를 n개 생성하려면????
# ---->runif(n) *m
#주사위 놀이(100개)
set.seed(100)
runif(100)*6 
set.seed(100)
runif(100)*6 + 1
set.seed(100)
as.integer(runif(100)*6 + 1)

# 정규분표 난수 발생 rnorm(n,mean,sd) 정규분포 N[평균,표준편차]의 난수를 n개 생성
rnorm(10,0,1)  # N(0,1) 난수 10개 발생

# 포아송분포(Poisson Distribution) 난수발생  rpois(n, lambda)  lambda : 단위시간 당 발생률
rpois(10, 2)


#7-16 데이터 조합
#조합(combination): 주어진 데이터값들 중에서 몇 개씩 짝을 지어 추출하는 작업

y= combn(1:5,3)                      # 1~5에서 3개를 뽑는 조합
y

for(i in 1:ncol(y)) {           # 조합을 출력
  cat(y[,i], "\n")
}

x = c("red","green","blue","black","white")
com <- combn(x,2)                 # x의 원소를 2개씩 뽑는 조합
com

for(i in 1:ncol(com)) {           # 조합을 출력
  cat(com[,i], "\n")
}


#7-17 데이터 집계 -  iris 데이터셋에서 각 변수의 품종별 평균 출력

agg <- aggregate(iris[,-5], by=list(iris$Species), 
                 FUN=mean)
agg

#집계 기준에 대하여 이름을 달아주자
agg <- aggregate(iris[,-5], by=list(품종=iris$Species), mean)
agg

#7-18 iris 데이터셋에서 각 변수의 품종별 표준편차 출력

agg <- aggregate(iris[,-5], by=list(표준편차=iris$Species),
                 FUN=sd)
agg


#7-19 mtcars 데이터셋에서 각 변수의 (실린더별, 엔진타입별) 최댓값 출력
head(mtcars)
agg <- aggregate(mtcars, by=list(mtcars$cyl, mtcars$vs),
                 FUN=max)
agg

agg <- aggregate(mtcars, by=list(cyl=mtcars$cyl,vs=mtcars$vs),
                 FUN=max)
agg

#7-20 데이터 병합(merge) - 분리된 데이터 파일을 공통 열을 기준으로 하나로 합치는 작업
#데이터베이스의 조인연산과 유사함
# 먼저 두개의 데이터셋을 만들어보자
x <- data.frame(name=c("a","b","c"), math=c(90,80,40))
y <- data.frame(name=c("a","b","d"), korean=c(75,60,90))
x
y

#7-21 이름을 기준으로 합쳐보자
z <- merge(x,y, by=c("name"))  #병합할 대상 : x,y  기준열 : name
z


#7-22  공통 열의 이름이 다를 때

merge(x,y, all.x=T)   # 첫 번째 데이터셋의 행들은 모두 표시되도록
merge(x,y, all.y=T)   # 두 번째 데이터셋의 행들은 모두 표시되도록
merge(x,y, all=T)     # 두 데이터셋의 모든 행들이 표시되도록


#7-23
x <- data.frame(name=c("a","b","c"), math=c(90,80,40))
y <- data.frame(sname=c("a","b","d"), korean=c(75,60,90))
x                         # 병합 기준 열의 이름이 name
y                         # 병합 기준 열의 이름이 sname
merge(x,y, by.x=c("name"), by.y=c("sname"))


#7-24
# 범주형변수 다루기
# 건강검진 데이터 예제 "health.csv"
wd<-getwd()
setwd(wd) 
df<-read.csv("health.csv")
head(df)
str(df)
df$SEX<-as.factor(df$SEX)
df$SEX<-factor(df$SEX)      #그냥 factor()도 무방
df$SMOK<-as.factor(df$SMOK)
df$ALCOHOL<-as.factor(df$ALCOHOL)
df$RESID<-as.factor(df$RESID)
df$TWIN<-as.factor(df$TWIN)
df$RH<-as.factor(df$RH)
df$HTN<-as.factor(df$HTN)
df$TRANSPORT<-as.factor(df$TRANSPORT)
str(df)

#7-25  연습문제 5-7 (7)

# R에서 제공하는 Orange 데이터셋에 대해
# 나무 둘레(circumference)에 대해 상자그림을 작성하되 그룹(Tree)을 구분하여 작성하시오.
str(Orange)
head(Orange)
# 그룹 정렬이 안된 상자그림
boxplot(circumference~Tree, 
        data=Orange,
        main='그룹별 둘레')

# 그룹 정렬을 적용한 상자그림

TreeOrder=factor(Orange$Tree , levels=levels(Orange$Tree)[c(2,4,1,5,3)])
#위문장 이해하기
Orange$Tree
levels(Orange$Tree)[c(2,4,1,5,3)]
TreeOrder

boxplot(Orange$circumference~TreeOrder, 
        main='그룹별 둘레')


#ex07_284p
library(mlbench)
data(Vehicle)

head(Vehicle)

#차량 유형(Class)을 기준으로 차량의 종횡비(Max.L.Ra) 평균을 구함
agg <- aggregate(Vehicle[,'Max.L.Ra'], by=list(차량타입=Vehicle$Class),
                 FUN=mean)
agg

# 차량 유형(Class)을 기준으로 차량의 종횡비(Max.L.Ra) 평균을 막대그래프로 나타냄
barplot(agg$x, names.arg=agg$차량타입, main='차량유형별 종횡비')
