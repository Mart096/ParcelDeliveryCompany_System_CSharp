declare @result varchar(max)

select @result = COALESCE(@result + ', ', '') + Cecha
from Cecha
WHERE Id_cechy IN (SELECT Id_cechy_paczki FROM Cecha_paczki WHERE Id_paczki = 1)

select @result

SELECT * FROM Paczka