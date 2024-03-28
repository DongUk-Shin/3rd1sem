#20204101
#신동욱
#빅데이터분석 6장 과제


#1
plot(dist~speed, data=cars)

#2
plot(pressure~temperature, data=pressure)

#3
pairs(swiss[,c('Fertility', 'Agriculture', 'Examination', 'Education')])

#4
point <- as.numeric(iris$Species)
color <- c('red', 'green', 'blue')
plot(Petal.Width~Petal.Length, data=iris, col=color[point])

#5
income <- c(121,99,25,35,40,30,150,24,50,60)
edutime <- c(19,20,16,16,18,12,24,12,16,17)
tbl <- data.frame(income,edutime)
tbl
plot(income~edutime, data=tbl)
res <- lm(income~edutime, data=tbl)
abline(res)
cor(income,edutime)

#6
humidity <- c(56,67,89,91,53,41,46,71,80,92)
rentals <- c(92510,74801,27168,33929,89807,92153,92045,75328,48756,21875)
tbl <- data.frame(humidity,rentals)
tbl
plot(humidity~rentals, data=tbl)
res <- lm(humidity~rentals, data=tbl)
abline(res)
cor(humidity,rentals)

#7
df <- data.frame(state.x77)
cor(df)
plot(df$Income, df$HS.Grad)

#8
Years <- c(2015,2016,2017,2018,2019,2020,2021,2022,2023,2024,2025,2026)
Population <- c(51014,51245,51446,51635,51811,51973,52123,52261,52388,52504,52609,52704)
df <- data.frame(Years,Population)
plot(Population~Years,data=df,type='l')

#9
Years <- c(20144,20151,20152,20153,20154,20161,20162,20163,20164,20171,20172,20173)
Men <- c(73.9,73.1,74.4,74.2,73.5,73,74.2,74.5,73.8,73.1,74.5,74.2)
Women <- c(51.4,50.5,52.4,52.4,51.9,50.9,52.6,52.7,52.2,51.5,53.2,53.1)
plot(Years,Women,type='l',ylab='gender',ylim=c(45,80),col='red')
lines(Years,Men,type='l',col='blue')

#10
plot(Girth~Height, data=trees)
cor(trees$Girth, trees$Height)

pairs(trees[,c('Girth', 'Height', 'Volume')])
cor(trees$Girth, trees$Height)
cor(trees$Girth, trees$Volume)
cor(trees$Volume, trees$Height)

#11
points <- as.numeric(Orange[,'Tree'])
colors <- c('red', 'orange', 'yellow', 'green', 'blue')
plot(Orange$age, Orange$circumference, col=colors[points])

#12
library(mlbench)
data('Glass')
myds <- Glass

pairs(myds[, 1:9])
cor(myds[, 1:9])
plot(myds[, 1:9], col=myds$Type)


#13
library(mlbench)
data('Ionosphere')
myds <- Ionosphere[,3:12]

cor(myds[, 1:10])
plot(myds$V9, myds$V11)
cor(myds$V9, myds$V11)

#14
years <- 1875:1972
hlevel <- as.vector(LakeHuron)
plot(x=years, y=hlevel, type='l', col='blue')

#15
y1949 <- c(112,118,132,129,121,135,148,148,136,119,104,118)
y1955 <- c(242,233,267,269,270,315,364,347,312,274,237,278)
y1960 <- c(417,391,419,461,472,535,622,606,508,461,390,432)
plot(x=y1949, type='l', col='red', ylim=c(100,650), xlab='Month', ylab='passengers')
lines(x=y1955, type='l', col='blue')
lines(x=y1960, type='l', col='green')

#16
y1973 <- USAccDeaths[1:12]
y1975 <- USAccDeaths[25:36]     
y1977 <- USAccDeaths[49:60]

plot(x=y1973, type='l', col='red', ylim=c(6000,12000), xlab='Month',ylab='Deaths')
lines(x=y1975, type='l', col='blue')
lines(x=y1977, type='l', col='green')

