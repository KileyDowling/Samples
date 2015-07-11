use
MovieCatalog
go

select count(m.MovieID) as NumOfMovies
from Movies m


select count(a.ActorID) as NumOfActors
from Actors a

select *
from Actors

select ma.MovieID, a.ActorID, m.Title, a.ActorID, a.FirstName, a.LastName
from MovieActors ma
	inner join Actors a on ma.ActorID = a.ActorID
	inner join Movies m on ma.MovieID = m.MovieID
order by a.ActorID, m.MovieID

select a.FirstName, a.LastName,count(a.ActorID) as NumOfFilms 
from MovieActors ma
	inner join Actors a on ma.ActorID = a.ActorID
	inner join Movies m on ma.MovieID = m.MovieID
group by a.FirstName, a.LastName

select ma.MovieID, ma.ActorID, m.Title, a.FirstName, a.LastName
from MovieActors ma
inner join Movies m on ma.MovieID = m.MovieID
inner join Actors a on ma.ActorID = a.ActorID
where ma.MovieID < 4

SELECT ActorID, FirstName, LastName, DateOfBirth
FROM Actors 
WHERE ActorID IN (SELECT ActorID FROM MovieActors WHERE MovieID = 3);
