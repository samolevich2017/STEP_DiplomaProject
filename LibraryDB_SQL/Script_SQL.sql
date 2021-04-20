-- ������� ������� "�����"
CREATE TABLE Books(
	id INT PRIMARY KEY IDENTITY(1,1),				 -- id �����
	Title NVARCHAR(255) NOT NULL,					 -- �������� �����
	AuthorId INT FOREIGN KEY REFERENCES Authors(id), -- ����� �����
	-- ���� �������� � ������� ����������
	DescriptionBook NVARCHAR(3000),					 -- �������� �����
	CoverImgURL NVARCHAR(1200) DEFAULT 'https://clck.ru/TSSWH', -- ������ �� ����������� ������� �����
	YearOfIssue NVARCHAR(10)						 --  ��� ������� �����
)

-- ������� ������� "������"
-- � ���� �������� ������� ������� ������ ������� "�����".
-- ��� ����� ���������� ����� "����-��-������". ���� � ��� �� �����,
-- ����� �������� ��������� ����. 
CREATE TABLE Authors(
	id INT PRIMARY KEY IDENTITY(1,1),
	SurnameNP NVARCHAR(300) NOT NULL
)

-- ������� ������� "�����"
-- � ���� ������� ����� ��������� ��� ��������� ����� ����.
-- ����� ��� ������� ������� � �������� "�����" � ������� 
-- ������� ���������� "����������". ����������� ����� "������-��-������".
-- � ��������� ���� ����� ���� ��������� ������. �� ����� �� ��������� ������
-- ����� ���������� ��������� ����.
CREATE TABLE Genres(
	id INT PRIMARY KEY IDENTITY(1,1),
	genreName NVARCHAR(255) NOT NULL
)

-- ������� ������� ���������� "����������"
CREATE TABLE BooksGenres(
	BookId INT FOREIGN KEY REFERENCES Books(id),
	GenreId INT FOREIGN KEY REFERENCES Genres(id),
	primary key (BookId, GenreId)
)

-- �������� ��� ����� ������� �������
INSERT INTO Authors
VALUES
	('����� �.�.'),
	('������� ������'),
	('���� �����'),
	('�������� ����'),
	('������� �����');

-- �������� ��� ����� ������� ������
INSERT INTO Genres
VALUES
	('���������'),
	('����������������'),
	('����������'),
	('���������� ����');

SELECT * FROM Authors;

-- ������� ��� ����� ������� ����
INSERT INTO Books (Title, AuthorId, DescriptionBook, YearOfIssue)
VALUES
	('����� � �������', 4, '�������� �����������', '2019 ���'),
	('������� ��������', 1, '��� �� ����� ���� ������� �������� ������������. ����� ����� ���...', '3012 ���'),
	('����� ��� ���������', 5, '������� �������, ��� ���������� � ��� ����, ���������� ����������� ����������������� �������������, ������� ���������� ��������� � ������ �������. � ����������� �������� � ���������� ��������������� �������� ����������. ������� �����, ������ ����, � ���� ����� ����������, ��� ������ ����� �������� ������ ������ �������� � �������� ��������, ������� ���������� ��� ����������� �� ������ ������. ��� ��������� ��������� ����������� ���� ���� � ������������ �� ���������� ��������, ��� ������ ����� �������� ������ ������ �������� � �������� ��������, ������� ���� ��� ������ ���������� ��� ����������� �� ������ � ������������ ������. �������� ��� �����, �� ���������: ���������� ������ ������ �� ����� ������� ������; ������� ����� ������������ (����������� ������ ����� �����); ��������� ��������� �������� ���� ���, ����� �� ���� ������� �������� � ������, � ������� � ������������ ������ ����� ����� ����� ������!', '2014 ���'),
	('������ �����', 3, '�������� �����������', '2016 ���'),
	('CLR via C#', 2, '��� �����, ��������� � ��������� ������� � ��� ������� ������������ ��������� �� ����������������, �������� ��������� ���������� ���������� � ���������������� ������������ ����������� ����� (CLR) Microsoft .NET Framework ������ 4.5. ���������� ���������� ��������� � ������� ���������������� ������� ��������, ����� ��� ���������� ������������� ������� ������������� .NET Framework �������� Microsoft, ����� ������ ��� ��������� ��-���������� �������� ���������� ������ ����, � ��� ����� � �������������� Microsoft Silverlight, ASP.NET, Windows Presentation Foundation � �.�.��������� ������� ��������� ��������� � ������������ �� ������������� ��������� .NET Framework 4.5, � ����� ����� Visual Studio 2012 � C# 5.0.', '2018 ���');

-- �������� ������� ��������� "����������". ��� ����� �������� ������ �����.
INSERT INTO BooksGenres
VALUES 
	(1, 1),
	(1, 3),
	(2, 4),
	(3, 3),
	(4, 1),
	(5, 2);

-- ������ ��� �����!!!
-- ������� ���������� � ������, ����� ��������� � ������������ ������ ������.
SELECT * FROM Books
JOIN Authors ON Books.AuthorId = Authors.id
JOIN BooksGenres ON BookId = Books.id
JOIN Genres ON GenreId = Genres.id;

-- ������� ������� "����������"
-- ������������ ������ �� ����������� ����.
-- ������� � �������� ���� ������� ������.
CREATE TABLE Copies(
	idCopy INT PRIMARY KEY IDENTITY(1,1),				-- ID ����������
	idBook INT UNIQUE FOREIGN KEY REFERENCES Books(id), -- ID �����
	Amount INT DEFAULT 0 NOT NULL,						-- ���-�� �����������
	AmountFreeCopies INT NOT NULL						-- ���-�� ��������� �����������
)

-- �������� ������� "����������" ��� �����
INSERT INTO Copies
VALUES
	(1, 3, 3),
	(2, 1, 1),
	(3, 5, 5),
	(4, 6, 6),
	(5, 4, 4);

-- ������� ����� � ����������� �� �����������
SELECT * FROM Copies
JOIN Books ON idBook = Books.id;

-- ������� ������� "��������"
-- �������� ���������� � ������������������ ���������.
CREATE TABLE Readers(
	id INT PRIMARY KEY IDENTITY(1,1),
	SurnameReader NVARCHAR(255) NOT NULL,
	NameReader NVARCHAR(255) NOT NULL,
	PatronymicReader NVARCHAR(255) NOT NULL,
	LoginReader NVARCHAR(24) NOT NULL,
	EmailReader NVARCHAR(254) NOT NULL,
	PasswordReader NVARCHAR(60) NOT NULL,
	AdressReader NVARCHAR(324) NOT NULL,
	PhoneNumberReader NVARCHAR(24) NOT NULL,
	PhotoReaderURL NVARCHAR(1200) NOT NULL
)

-- �������� ������� ���������
INSERT INTO Readers
VALUES
	('��������','��������','�����������', 'KristinaFedorova179', 'Fedorova179@gmail.com', 'nFRLA48bH1AW', '413750, �. ���, ��. ������������� 5217-� ������, ��� 126, �������� 358', '+7 (974) 342-26-38', 'https://randus.org/photos/w/41e37060606764f8.jpg');

-- ������� ������� "������������"
-- �������� ���������� � ����������� ����������.
CREATE TABLE Librarians(
	id INT PRIMARY KEY IDENTITY(1,1),
	SurnameLibrarian NVARCHAR(255) NOT NULL,
	NameLibrarian NVARCHAR(255) NOT NULL,
	PatronymicLibrarian NVARCHAR(255) NOT NULL,
	CodeLibrarian NVARCHAR(6) UNIQUE NOT NULL
)

-- �������� ������� "������������"
INSERT INTO Librarians
VALUES
	('��������������', '�����', '��������', '676767'),
	('���������', '�����', '��������', '231243');

-- ������� ������� "������ � �����"
-- �������� ���������� � ���� ��������������� ����������� ����
CREATE TABLE BookingRecords(
	id INT PRIMARY KEY IDENTITY(1,1),
	idReader INT FOREIGN KEY REFERENCES Readers(id),
	idBook INT FOREIGN KEY REFERENCES Books(id),
	BookingDate DATE NOT NULL,
	DateOfCompletion DATE NOT NULL
)

-- �������� ������� ������� � �����
INSERT INTO BookingRecords
VALUES
	(1, 2, '2021-02-25', '2021-02-28'),
	(1, 4, '2021-02-25', '2021-02-28');

-- ������� ������ � ��������������� ������
SELECT * FROM BookingRecords
JOIN Readers ON idReader = Readers.id
JOIN Books ON idBook = Books.id;

-- ������� ������� "������ ����"
-- ������ ������ � ������� ����������� ����������� ���� ���������
CREATE TABLE LendingBooks(
	id INT PRIMARY KEY IDENTITY(1,1),
	idLibrarian INT FOREIGN KEY REFERENCES Librarians(id) NOT NULL,
	idCopy INT FOREIGN KEY REFERENCES Copies(idCopy) NOT NULL,
	idReader INT FOREIGN KEY REFERENCES Readers(id) NOT NULL,
	DateOfIssue DATE NOT NULL,
	ExpectedDateOfReturn DATE NOT NULL, 
	ActualReturnDate DATE,
	StatusNode BIT DEFAULT (0) NOT NULL -- ������ (����� ��/����������)
)

-- ������� ������� "����� ��������"
-- ������ ���������� � ���� ��������� �������� � �������
-- ���� �� �� ��������� ����� (�����, ���������, ����� � ��...)
CREATE TABLE ReadersShelfs(
	id INT PRIMARY KEY IDENTITY(1,1),
	idReader INT FOREIGN KEY REFERENCES Readers(id) NOT NULL,
	idBook INT FOREIGN KEY REFERENCES Books(id) NOT NULL,
	idCategoryShelf INT FOREIGN KEY REFERENCES CategoriesShelfs(id) NOT NULL
)

-- ������� ������� "��������� �����"
CREATE TABLE CategoriesShelfs(
	id INT PRIMARY KEY,
	Category NVARCHAR(160) NOT NULL
)

-- �������� ������� "��������� �����"
INSERT INTO CategoriesShelfs
VALUES
	(1, '���������'),
	(2, '�������������'),
	(3, '������ � ������'),
	(4, '� �������� ������');

-- ������� ��������� ����� ��� ��������
SELECT * FROM CategoriesShelfs;