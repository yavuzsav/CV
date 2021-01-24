create database DapperCV
go
use DapperCV
go
create table AppUsers
(
    Id               int identity (1,1),
    FirstName        nvarchar(100),
    LastName         nvarchar(100),
    Address          nvarchar(500),
    Email            nvarchar(100),
    ImageUrl         nvarchar(500),
    PhoneNumber      nvarchar(50),
    ShortDescription nvarchar(1000),
    Username         nvarchar(50),
    PasswordHash     nvarchar(500),
    primary key (Id)
)
    go
create table SocialMediaIcons
(
    Id        int identity (1,1),
    Link      nvarchar(500),
    Icon      nvarchar(500),
    AppUserId int,
    primary key (Id),
    foreign key (AppUserId) references AppUsers (Id) on delete cascade
)
    go
create table Experiences
(
    Id          int identity (1,1),
    Title       nvarchar(200),
    SubTitle    nvarchar(500),
    Description nvarchar(1000),
    StartData   datetime,
    EndTime     datetime,
    primary key (Id)
)
    go
create table Educations
(
    Id          int identity (1,1),
    Title       nvarchar(200),
    SubTitle    nvarchar(500),
    Description nvarchar(1000),
    StartDate   datetime,
    EndDate     datetime,
    primary key (Id)
)
    go
create table Skills
(
    Id          int identity (1,1),
    Description nvarchar(100),
    primary key (Id),
)
    go
create table SkillIcons
(
    Id      int identity (1,1),
    Icon    nvarchar(500),
    SkillId int,
    foreign key (SkillId) references Skills (Id) on delete cascade
)
    go
create table Interests
(
    Id int identity (1,1),
    Description nvarchar(3000),
    primary key (Id)
)
    go
create table Certifications
(
    Id int identity (1,1),
    Description nvarchar(500),
    primary key (Id)
)