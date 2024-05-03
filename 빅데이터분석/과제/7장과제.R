#20204101 신동욱

#14
#1
subway <- read.csv('./subway.csv')
subway_latlong <- read.csv('./subway_latlong.csv')
subway.tot <- merge(x = subway, y = subway_latlong, 
                    by.x = c("station"), by.y = c("STATION_CD"))
subway.tot

#2
aggregate(x = subway.tot[,c("on_tot", "off_tot")], 
          by = list(NAME = subway.tot$stat_name, DATE = subway.tot$income_date), FUN = sum)

#3
#2011 추출해서 변수에 저장
subway_2011 <- subway.tot[which(substr(subway.tot$income_date, 1, 4) == "2011"),] 
aggregate(x = subway_2011[, c("on_tot", "off_tot")],
          by = list(NAME = subway_2011$stat_name),
          FUN = sum)

#4
aggregate(x = subway_2011[, c("on_tot", "off_tot")], 
          by = list(LINE_NUM = subway_2011$LINE_NUM), FUN = sum)



#15
authors <- data.frame(
  surname = c("Twein", "Venables", "Tierney", "Ripley", "McNeil"),
  nationality = c("US", "Australia", "US", "UK", "Australia"),
  retired = c("yes", rep("no", 4)))
books <- data.frame(
  name = c("Johns", "Venables", "Tierney", "Ripley", "Ripley", "McNeil"),
  title = c("Exploratory Data Analysis",
            "Modern Applied Statistics ...",
            "LISP-STAT",
            "Spatial Statistics", "Stochastic Simulation",
            "Interactive Data Analysis"),
  other.author = c(NA, "Ripley", NA, NA, NA, NA))



#1
merge(x=authors, y=books, by.x='surname', by.y='name')

#2
merge(x=authors, y=books, by.x='surname', by.y='name', all.x=TRUE)

#3
merge(x=authors, y=books, by.x='surname', by.y='name', all.y=TRUE)

#4
merge(x=authors, y=books, by.x='surname', by.y='other.author')
