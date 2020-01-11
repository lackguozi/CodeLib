/*
SQLServerFORXMLPATH+GROUPBY语句的应用(拼字段)
for xml path有的人可能知道有的人可能不知道，其实它就是将查询结果集以XML形式展现，
可以 和 stuff一起使用
主要使用将多行数据变为一行显示
stuff(param1, startIndex, length, param2)
将param1中自startIndex(SQL中都是从1开始，而非0)起，删除length个字符，然后用param2替换删掉的字符
*/


select id，name，mark =(stuff(select '，'+mark from grade where grade.id =a.id for xml path('')),1,1,'') from sutdent a group by name,id；




