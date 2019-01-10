use Chinook
--8
--SELECT Title As AlbumTitle, Name AS ArtistName
--from album join Artist 
--on Album.ArtistId = Artist.artistid

--10
--SELECT TOP 10 COUNT (*) AS NrOfAlbums, Name AS ArtistName
--FROM Album JOIN Artist
--on Album.ArtistId = Artist.ArtistId
--GROUP BY Artist.Name ORDER BY NrOfAlbums DESC 

--11
--SELECT DISTINCT Album.Title AS AlbumTitle, Genre.Name
--FROM Album, Track, Genre
--WHERE Album.AlbumId = Track.AlbumId
--AND Track.GenreId = Genre.GenreId
--AND (Genre.Name = 'Jazz' OR Genre.Name = 'Blues')

--12

--SELECT TrackNr, Track.Name
--FROM Track, Album
--WHERE Track.AlbumId = Album.AlbumId
--AND Album.Title = 'Let There Be Rock'

--ORDER BY TrackNr

--13

--SELECT TOP 5 COUNT (*) AS NrOfTracks, Genre.Name AS GenreName
--FROM Genre, Track
--WHERE Track.GenreId = Genre.GenreId
--GROUP BY Genre.Name
--HAVING COUNT (*) > 100
--ORDER BY NrOfTracks DESC

--15

--SELECT Customer.FirstName AS CustomerFirstName, 
--Customer.LastName AS CustomerLastName, 
--Employee.FirstName AS SupportFirstName,
--Employee.LastName AS SupportLastName
--INTO CustomerWithSupport
--FROM Customer, Employee
--WHERE Customer.SupportRepId = Employee.EmployeeId

--16

--SELECT A.FirstName + ' ' + A.LastName AS EmployeeName, 
--B.FirstName + ' ' + B.LastName AS Bossname
--FROM Employee A, Employee B
--WHERE A.ReportsTo = B.EmployeeId

--17

--SELECT TOP 1 MAX(LEN(Customer.Email)) AS LongestMail
--FROM Customer

--18

--SELECT TOP 1  WITH TIESTrack.Name, Milliseconds/60000 AS Minutes
--FROM Track
--ORDER BY Track.Milliseconds DESC

--19

--ALTER TABLE Customer
--ADD UNIQUE (Phone);

--20

--SELECT YEAR(Invoice.InvoiceDate) AS Year, SUM(Total) AS Sum
--FROM Invoice
--GROUP BY YEAR(Invoice.InvoiceDate)
--ORDER BY YEAR(Invoice.InvoiceDate) DESC

--21

--SELECT TOP 1 Playlist.Name AS Name, SUM(Track.Milliseconds/3600000.0) AS TotalLengthInHours
--FROM Playlist
--JOIN PlaylistTrack ON PlaylistTrack.PlaylistId=Playlist.PlaylistId
--JOIN Track ON Track.TrackId =PlaylistTrack.TrackId
--GROUP BY PlaylistTrack.PlaylistId, Playlist.Name

--22

--SELECT A.FirstName + ' ' + A.LastName AS EmployeeName, 
--C.FirstName + ' ' + C.LastName AS BossesBossName
--FROM Employee A, Employee B, Employee C
--WHERE A.ReportsTo = B.EmployeeId AND B.ReportsTo = C.EmployeeId

--23


--SELECT Title, AlbumReview.Review
--FROM AlbumReview
--WHERE Review IS NOT NULL

--EXTRA 3

--BACKUP DATABASE Chinook
--TO DISK = 'C:\TMP\ChinookDB.bak'

--ALTER TABLE PlaylistTrack
--DROP  FK_PlaylistTrackPlaylistId
--DELETE FROM Playlist
--SELECT *
--FROM Playlist
--RESTORE DATABASE Chinook
--FROM DISK = 'C:\TMP\ChinookDB.bak'
--SELECT * 
--FROM Playlist

--EXTRA 4
--INSERT INTO Artist(Name)
--VALUES ('Genesis'),('Jethro Tull'),('Yes'),('Peter Hammill'),('Van Der Graaf Generator')
--ROLLBACK
--SELECT *
--FROM Artist
--DELETE Artist
--WHERE ArtistId > 275
--SELECT *
--FROM Artist
--BEGIN TRANSACTION
--INSERT INTO Artist(Name)
--VALUES ('Genesis'),('Jethro Tull'),('Yes'),('Peter Hammill'),('Van Der Graaf Generator')
--ROLLBACK
--SELECT *
--FROM Artist

--EXTRA 5

--SELECT *
--FROM Album
--BEGIN TRANSACTION
--ALTER TABLE Track
--DROP FK_TrackAlbumId

--ALTER TABLE Album
--DROP PK_Album


--ALTER TABLE Album
--ALTER COLUMN AlbumId smallint
--ALTER TABLE Album
--ADD CONSTRAINT PK_Album PRIMARY KEY (AlbumId)

ALTER TABLE Track
Alter COLUMN AlbumId smallint
--ALTER TABLE Track
--ADD FOREIGN KEY (AlbumId) REFERENCES Album(AlbumId)

