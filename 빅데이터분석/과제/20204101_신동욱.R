#20204101
#신동욱 
#빅데이터분석 과제#1


#1
  #1-1
  tabaco <- esoph[,'tobgp']
  tabaco
  #1-2
  unique(tabaco)
  tabaco
  #1-3
  table(tabaco)
  table(tabaco)/length(tabaco)
  #1-4
  ds <- table(tabaco)
  ds
  barplot(ds)

#2
  #2-1
  result <- c('P', 'P', 'F', 'P', 'F', 'P', 'F', 'P', 'P', 'F')
  #2-2
  table(result)
  table(result)/length(result)
  #2-3
  ds <- table(result)
  ds
  barplot(ds)
  #2-4
  pie(ds)

#3
  #3-1
  season <- c('여름', '겨울', '봄', '가을', '여름', '가을', '겨울', '여름', '여름', '가을')
  #3-2
  table(season)
  table(season)/length(season)
  #3-3
  ds <- table(season)
  ds
  barplot(ds)
  #3-4
  pie(ds)

#4
  #4-1
  score <- c(90, 85, 73, 80, 85, 65, 78, 50, 68, 96)
  names(score) <- c('KOR', 'ENG', 'ATH', 'HIST', 'SOC', 'MUSIC', 'BIO', 'EARTH', 'PHY', 'ART')
  #4-2
  score
  #4-3
  mean(score)
  median(score)
  #4-4
  sd(score)
  #4-5
  which.max(score)
  #4-6
  boxplot(score)
  boxplot.stats(score)
  #4-7
  hist(score, main='학생 점수', col ='purple')
  
#5
  #5-1
  mean(mtcars[,'wt'])
  median(mtcars[,'wt'])
  median(mtcars[,'wt'], trim=0.15)
  sd(mtcars[,'wt'])
  #5-2
  summary(mtcars[,'wt'])
  #5-3
  table(mtcars[,'cyl']/length(mtcars[,'cyl']))
  #5-4
  barplot(table(mtcars[,'cyl']/length(mtcars[,'cyl'])))
  #5-5
  hist(mtcars[,'wt'])
  #5-6
  boxplot(mtcars[,'wt'])
  boxplot.stats(mtcars[,'wt'])
  #5-7
  boxplot(mtcars[,'disp'])
  boxplot.stats(mtcars[,'disp'])
  #5-8
  boxplot(mpg~gear,mtcars)
  
  
  
  
#6
  #6-1
  head(trees)
  #6-2
  mean(trees[,'Girth'])
  median(trees[,'Girth'])
  mean(trees[,'Girth'], trim=0.15)
  sd(trees[,'Girth'])
  #6-3
  hist(trees[,'Girth'])
  #6-4
  boxplot(trees[,'Girth'])
  #6-5
  mean(trees[,'Height'])
  median(trees[,'Height'])
  mean(trees[,'Height'], trim=0.15)
  sd(trees[,'Height'])
  #6-6
  hist(trees[,'Height'])
  #6-7
  boxplot(trees[,'Height'])
  
#7
  #7-1
  head(Orange)
  #7-2
  mean(Orange[,'age'])
  median(Orange[,'age'])
  mean(Orange[,'age'], trim=0.15)
  sd(Orange[,'age'])
  #7-3
  hist(Orange[,'age'])
  #7-4
  boxplot(age~Tree, Orange)
  #7-5
  orange2 <- subset(Orange, Tree!=2)
  mean(orange2[,'circumference'])
  median(orange2[,'circumference'])
  mean(orange2[,'circumference'], trim=0.15)
  sd(orange2[,'circumference'])
  #7-6
  hist(orange2[,'circumference'])
  #7-7
  boxplot(circumference ~ Tree, Orange)
