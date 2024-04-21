# tidyverse의 세계

install.packages('tidyverse')
library(tidyverse)

head(iris)
iris %>% head()
iris %>% summary()

# select와 filter
# select 출력할 컬럼 지정
# filter 출력할 행 지정

temp <- select(iris, Sepal.Length, Sepal.Width, Species)
head(temp)
iris %>% select(Sepal.Length, Sepal.Width, Species) %>% head()

filter(iris, Species=='setosa' & Sepal.Length>5.5)
iris %>% filter(Species=='setosa' & Sepal.Length>5.5)

#이 것들을 조합하면 SQL의 select * from where 처럼 사용 가능
# Sepal.Length > 7.5인 것들의 Sepal.Length와 Species를 출력

iris %>% select(Sepal.Length, Species) %>% filter(Sepal.Length>7.5)

# select와 filter의 순서를 바꾸어도 동일한 결과
iris %>% filter(Sepal.Length>7.5) %>% select(Sepal.Length, Species) 

# group_by()
#컬럼을 기준으로 그룹화를 할 때 사용

group_by(iris, Species)
iris %>% group_by(Species=='setosa')

# group_by() 함수만으로는 큰 의미가 없음
# group_by() 함수를 이용해서 그룹화를 할 땐, 어떻게 집계를 할지에 대한 부분을 명시해야 함
# summarize() 함수를 통해 이 부분을 명시할 수 있음

summarize(group_by(iris, Species),sum(Sepal.Length))
iris %>% group_by(Species) %>% summarize(sum(Sepal.Length))

# 새로운 열 생성, mutate()
mutate(temp, Sratio = Sepal.Length / Sepal.Width)
temp %>% mutate(Sratio = Sepal.Length / Sepal.Width) %>% head()

# arrange()를 아용한 정렬

arrange(iris, iris$Sepal.Length)
arrange(iris, desc(iris$Sepal.Length))

#새로운 컬럼 생성 후 정렬
temp1 <-mutate(temp, Sratio = Sepal.Length / Sepal.Width)
arrange(temp1,Sratio)

#temp1생성 없이 파이프로 처리해보자

temp %>% mutate(Sratio = Sepal.Length /  Sepal.Width)  %>% arrange(temp,Sratio) %>% head()
temp %>% mutate(Sratio = Sepal.Length /  Sepal.Width)  %>% arrange(temp,desc(Sratio)) %>% head()  
