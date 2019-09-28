--Created by : Bishwajit Barua

--DROP DATABASE Music;
CREATE DATABASE Music;


USE Music;
GO
IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS
        WHERE TABLE_NAME = 'tblMusic')
    DROP TABLE tblMusic
GO
CREATE TABLE tblMusic
(
 Id int,
 SongName nvarchar(50),
 Artist nvarchar(50),
 Album nvarchar(50),
 ReleaseYear nvarchar(5)
);
GO

INSERT INTO tblMusic VALUES (1, 'Avalon', 'Bryan Farry - Roxy Music','Street Life - 20 Great Hits', '1998');
INSERT INTO tblMusic VALUES (2, 'Believe', 'Cher','Believe', '1998');
INSERT INTO tblMusic VALUES (3, 'Boom Boom', 'Big Heard Todd & the Monster','Beautiful World', '1997');


IF OBJECT_ID ( 'spGetMusic', 'P' ) IS NOT NULL 
    DROP PROCEDURE spGetMusic;
GO
CREATE PROCEDURE spGetMusic
@name nvarchar(50)
AS
BEGIN
	 SELECT Id, SongName, Artist, Album, ReleaseYear
	 FROM tblMusic 
	 WHERE SongName = @name
END;
