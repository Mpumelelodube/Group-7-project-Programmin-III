CREATE TABLE employee (
    id VARCHAR(15) PRIMARY KEY,
    firstName VARCHAR(50),
    LastName VARCHAR(50),
    dob VARCHAR(10),
    gender VARCHAR(2),
    salary FLOAT,
    brachID VARCHAR(10),
    PhoneNumber int,
    Email varchar(255),
    Adress varchar(255),
    desegnation varchar(2)
)
 
CREATE TABLE brach (
    brachID VARCHAR(10) PRIMARY KEY,
    branchName VARCHAR(20),
    managerId VARCHAR(10)
);
 
create table admnin(
	id varchar(10) primary key,
	 firstName VARCHAR(50),
    LastName VARCHAR(50),
	password varchar(20)
);