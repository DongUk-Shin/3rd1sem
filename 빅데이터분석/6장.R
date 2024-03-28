str(iris)
iris
# setosa에 대하여 (Sepal.Length, Sepal.Width) 산점도를 그리자
temp <- subset(iris, Species == 'setosa')   # setosa애 대해서만
plot(temp$Sepal.Length, temp$Sepal.Width,
     pch=19, col="black")

cor(temp$Sepal.Length, temp$Sepal.Width) # 상관계수

#6.1 두 변수 간의 산점도
str(mtcars)
wt <- mtcars$wt                  # 중량 자료
mpg <- mtcars$mpg                # 연비 자료
plot(wt, mpg,                    # 2개 변수(x축, y축)
     main="중량-연비 그래프",    # 제목
     xlab="중량",                # x축 레이블
     ylab="연비(MPG)",           # y축 레이블
     col="red",                  # point의 color
     pch=19)                     # point character의 종류

# 혹은

plot(mtcars$wt, mtcars$mpg,        
     main="중량-연비 그래프",    
     xlab="중량",                
     ylab="연비(MPG)",          
     col="blue",                 
     pch="a")                    

# 혹은

plot(mtcars[, c("wt", "mpg")],        
     main="중량-연비 그래프",    
     xlab="중량",                
     ylab="연비(MPG)",          
     col="blue",                 
     pch=22)   

# 혹은

plot(mtcars[, c(6,1)],        
     main="중량-연비 그래프",    
     xlab="중량",                
     ylab="연비(MPG)",          
     col="blue",                 
     pch="ㅋ")             
#========================
# 다음은 모두 같은 표현임
# mtcars$wt, mtcars$mpg
# mtcars[, c("wt", "mpg")
# mtcars[, c(6,1)]
#========================


#6.2 여러 변수 간의 산점도

vars <- c("mpg","disp","drat","wt")    # 대상 변수
target <- mtcars[,vars]
head(target)
pairs(target,                          # 대상 데이터
      main="Multi Plots")

#6.3 그룹정보가 있는 두 변수의 산점도

iris.34 <- iris[,3:4]
head(iris.34)
point <- as.numeric(iris$Species)      # 팩터타입으로되어 있는 품종을 숫자 1,2,3으로 변환
iris$Species                           # setosa, versicolor, virginica의 값을 가짐
point                                  # 1=setosa, 2=versicolor, 3=virginica
color <- c("red","green","blue")       # 점의 컬러
plot(iris.34,
     main="Iris plot",
     pch=c(point),
     col=color[point])

plot(iris.34,
     main="Iris plot",
     pch=c(point+5),
     col=color[point])

# 6.4 음주량과 혈중알콜농도에 대한 상관 분석

beers = c(5,2,9,8,3,7,3,5,3,5)                 # 자료 입력
bal <- c(0.1,0.03,0.19,0.12,0.04,0.0095,0.07,  # 자료 입력
         0.06,0.02,0.05)
tbl <- data.frame(beers,bal)                   # 데이터프레임 생성
tbl
plot(bal~beers,data=tbl)                       # 산점도

# 다음과 같이 해도 무방. 그러나 bal~beers는 beers:독립, abl :종속임을 의미함

plot(tbl[, c("beers", "bal")],        
     main="음주량-알콜농도 그래프",    
     xlab="음주량",                
     ylab="알콜농도",          
     col="blue",                 
     pch=3)   

res <- lm(bal~beers,data=tbl)                  # 회귀식 도출 (linear model)
abline(res)                                    # 회귀선 그리기(y=a+b*x)
cor(beers,bal)                                 # 상관계수 계산
summary(res)                                   # 회귀분석 결과보기

# 완전상관관계란 무엇인가?
# 다음과 같이 점들이 1직선 상에 모일경우
x <- 1:10
y <- 1:10
z <- 10:1
w <- data.frame(x,y,z)
pairs(w)

# 상관계수을 구해보면...
cor(x,y)
cor(x,z)

# 6.5  여러 변수 간의 상관계수 구하기

cor(iris[,1:4])               # 4개 변수 간 상관성 분석



# 6.6 선스래프 그리기
month = 1:12                          # 자료 입력
late = c(5,8,7,9,4,6,12,13,8,6,6,4)   # 자료 입력
plot(month,                           # x data
     late,                            # y data
     main="지각생 통계",              # 제목
     type= "S",                       # 그래프의 종류 선택(알파벳)
     lty=1,                           # 선의 종류(line type) 선택
     lwd=1,                           # 선의 굵기 선택
     xlab="Month",                    # x축 레이블
     ylab="Late cnt"                  # y축 레이블
)

# 그래프의 종류 선택
# type="p" 점 모양 그래프 (기본값) 
# type="l"  선 모양 그래프 (꺾은선 그래프) 
# type="b"  점과 선 모양 그래프 
# type="c"  "b"에서 점을 생략한 모양 
# type="o"  점과 선을 "중첩"해서 그린 그래프 "b"와 유사
# type="h"  각 점에서 x축 까지의 수직선 그래프 
# type="s"  왼쪽값을 기초로 계단모양으로 연결한 그래프 
# type="S"  오른쪽 값을 기초로 계단모양으로 연결한 그래프 


# 6.7  여러 선 그리기
month = 1:12
late1 = c(5,8,7,9,4,6,12,13,8,6,6,4)
late2 = c(4,6,5,8,7,8,10,11,6,5,7,3)
plot(month,                          # x data
     late1,                          # y data
     main="Late Students",
     type= "b",                      # 그래프의 종류 선택(알파벳)
     lty=1,                          # 선의 종류(line type) 선택
     col="red",                      # 선의 색 선택
     xlab="Month ",                  # x축 레이블
     ylab="Late cnt",                # y축 레이블
     ylim=c(1, 15)                   # y축 값의 (하한, 상한)
)

# plot 함수로 그림 도표에 선을 표시(type= "b")
# lines : plot 함수로 그림 그림위에 덧붙여줌


lines(month,                         # x data
      late2,                         # y data
      type = "b",                    # 선의 종류(line type) 선택
      col = "blue")                  # 선의 색 선택



# 하나더 추가해보자
late3 = c(5,2,3,4,5,7,5,2,6,7, 4,1)
lines(month,                         # x data
      late3,                         # y data
      type = "b",                    # 선의 종류(line type) 선택
      col = "green") 

#직선의 방정식(회귀선) 추가
# abline : 기울기(=a)와 절편(=b)을 가지는 회귀선(y=a+b*x)을 그려줌

abline(a=2,b=1)

# 6.8 자료 탐색 실습

## 자료 준비 : BostonHousing데이터 셋은 mlnench 라이브러리에 있음
# 먼저 라이브러리 설치
install.packages("mlbench")
library(mlbench)
data(BostonHousing)
head(BostonHousing)
help(BostonHousing)  # 설명을 보고 싶을 땐 언제든 help를 사용!!

myds <- BostonHousing[,c("crim","rm","dis","tax","medv")]

##  그룹핑을 위한 컬럼(grp)을 하나 만들자
grp <- c()
for (i in 1:nrow(myds)) {                    # myds$medv 값에 따라 그룹 분류
  if (myds$medv[i] >= 25.0) {
    grp[i] <- "H"
  } else if (myds$medv[i] <= 17.0) {
    grp[i] <- "L"
  } else {
    grp[i] <- "M"
  }
}
grp

# 문자벡터를 팩터 타입으로 변경
grp <- factor(grp)  
grp

# 레벨의 순서를 H,L,M -> H,M,L
grp <- factor(grp, levels=c("H","M","L"))    

# myds에 grp 컬럼 추가
myds <- data.frame(myds, grp)                
str(myds)
head(myds)

# 주택 가격 그룹별 도수분포
table(myds$grp)                              

## 각 변수에 대한 히스토그램 그리기

par(mfrow=c(2,3))                            # 2x3 가상화면 분할
for(i in 1:5) {
  hist(myds[,i], main=colnames(myds)[i], col="yellow")
}

# 변수 별로 그래프 색상을 바꿔보자
par(mfrow=c(2,3))
col_vector <-c("red", "yellow", "green", "gray", "pink")
for(i in 1:5) {
  hist(myds[,i], main=colnames(myds)[i], col=col_vector[i])
}


## 상자그림그리기
par(mfrow=c(2,3))                            # 2x3 가상화면 분할
for(i in 1:5) {
  boxplot(myds[,i], main=colnames(myds)[i])
}
par(mfrow=c(1,1))                            # 2x3 가상화면 분할 해제

## 그룹별 상자그림 그리기
boxplot(myds$crim~myds$grp, main="1인당 범죄율")
boxplot(myds$rm~myds$grp, main="방의 수")
boxplot(myds$dis~myds$grp, main="직업센터까지의 거리")
boxplot(myds$tax~myds$grp, main="재산세")

## 산점도 그리기 (grp항목 제거하고 그리기)
pairs(myds[,-6])

## 그룹별 산점도 그리기
point <- as.integer(myds$grp)                # 점의 모양 지정
color <- c("red","green","blue")             # 점의 색 지정
pairs(myds[,-6], pch=point, col=color[point])

## 5개 항목에 대한 상관계수 구하기
cor(myds[,-6])


# 239쪽 실전분석
help(airquality)
# [,1]	평균Ozone량	 (ppb)
# [,2]	Solar.R	태양복사 (lang)
# [,3]	Wind	평균풍속 (mph)
# [,4]	Temp	최대온도 (degrees F)
# [,5]	Month	 (1~12)
# [,6]	Day	 (1~31)

tmp <- airquality[,1:4]  # 4개 변수만 취함
tmp
tmp <- tmp[complete.cases(tmp),] # 결측치 제거
head(tmp)
plot(tmp)   # 4변수에 대한 산점도
cor(tmp)    # 4변수에 대한 상관계수

cor(tmp$Ozone, tmp$Temp)
plot(tmp$Ozone, tmp$Temp, main="오존-온도")
