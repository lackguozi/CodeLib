SELECT AVG (DISTINCT income)
FROM (SELECT t1.income FROM Graduates t1,Graduates t2
								GROUP BY t1.income
								--s1 的条件
								HAVING SUM(CASE WHEN t2.income >= t1.income THEN 1 ELSE 0 END) 
														>= COUNT(*) / 2
							  --s2的条件
								AND SUM(CASE WHEN t2.income <= t1.income THEN 1 ELSE 0 END)
														>= COUNT(*) / 2) TMP;
--————————————————

--原文链接：https://blog.csdn.net/yjw123456/article/details/100988587

/*
相当于一个全连接把，首先将要查询的数分组，然后再  连接另一个相同的表，依次判断比这个数大于等于的数有多少个，
小于等于的数有多少个，与数的一半相比较，说起来比较简单，但是第一次思考可能会遇到困难
*/