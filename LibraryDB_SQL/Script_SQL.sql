-- Создаем таблицу "Книги"
CREATE TABLE Books(
	id INT PRIMARY KEY IDENTITY(1,1),				 -- id книги
	Title NVARCHAR(255) NOT NULL,					 -- название книги
	AuthorId INT FOREIGN KEY REFERENCES Authors(id), -- автор книги
	-- жанр отдельно в таблице посреднике
	DescriptionBook NVARCHAR(3000),					 -- описание книги
	CoverImgURL NVARCHAR(1200) DEFAULT 'https://clck.ru/TSSWH', -- ссылка на изображение обложки книги
	YearOfIssue NVARCHAR(10)						 --  год издания книги
)

-- Создаем таблицу "Авторы"
-- С этой таблицей связана внешним ключем таблица "Книги".
-- Тем самым реализовав связь "один-ко-многим". Один и тот же автор,
-- может написать множество книг. 
CREATE TABLE Authors(
	id INT PRIMARY KEY IDENTITY(1,1),
	SurnameNP NVARCHAR(300) NOT NULL
)

-- Создаем таблицу "Жанры"
-- В этой таблице будут храниться все возможные жанры книг.
-- Также эта таблица связана с таблицей "Книги" с помощью 
-- таблицы посредника "КнигиЖанры". Реализована связь "многие-ко-многим".
-- У множества книг может быть множество жанров. Но также ко множеству жанров
-- может относиться множество книг.
CREATE TABLE Genres(
	id INT PRIMARY KEY IDENTITY(1,1),
	genreName NVARCHAR(255) NOT NULL
)

-- Создаем таблицу посредника "КнигиЖанры"
CREATE TABLE BooksGenres(
	BookId INT FOREIGN KEY REFERENCES Books(id),
	GenreId INT FOREIGN KEY REFERENCES Genres(id),
	primary key (BookId, GenreId)
)

-- Заполним для теста таблицу авторов
INSERT INTO Authors
VALUES
	('Попов Е.Г.'),
	('Джеффри Рихтер'),
	('Бодо Шефер'),
	('Наполеон Хилл'),
	('Барбара Оакли');

-- Заполним для теста таблицу жанров
INSERT INTO Genres
VALUES
	('Экономика'),
	('Программирование'),
	('Психология'),
	('Личностный рост');

SELECT * FROM Authors;

-- Заполни для теста таблицу книг
INSERT INTO Books (Title, AuthorId, DescriptionBook, YearOfIssue)
VALUES
	('Думай и богатей', 4, 'Описание отсутствует', '2019 год'),
	('Богатая фантазия', 1, 'Это на самом деле больная фантазия разработчика. Такой книги нет...', '3012 год'),
	('Думай как математик', 5, 'Принято считать, что математики — это люди, наделенные недюжинными интеллектуальными способностями, которые необходимо развивать с самого детства. И большинству точность и логичность математического мышления недоступна. Барбара Оакли, доктор наук, в этой книге доказывает, что каждый может изменить способ своего мышления и овладеть приемами, которые используют все специалисты по точным наукам. Она призывает читателей тренировать свой мозг и подтверждает на конкретных примерах, что каждый может изменить способ своего мышления и овладеть приемами, которые явно или неявно используют все специалисты по точным и естественным наукам. Прочитав эту книгу, вы научитесь: эффективно решать задачи из любой области знаний; освоите метод интерливинга (чередование разных типов задач); научитесь «сжимать» ключевые идеи так, чтобы их было удобнее удержать в памяти, и узнаете о возможностях своего мозга очень много нового!', '2014 год'),
	('Азбука денег', 3, 'Описание отсутствует', '2016 год'),
	('CLR via C#', 2, 'Эта книга, выходящая в четвертом издании и уже ставшая классическим учебником по программированию, подробно описывает внутреннее устройство и функционирование общеязыковой исполняющей среды (CLR) Microsoft .NET Framework версии 4.5. Написанная признанным экспертом в области программирования Джеффри Рихтером, много лет являющимся консультантом команды разработчиков .NET Framework компании Microsoft, книга научит вас создавать по-настоящему надежные приложения любого вида, в том числе с использованием Microsoft Silverlight, ASP.NET, Windows Presentation Foundation и т.д.Четвертое издание полностью обновлено в соответствии со спецификацией платформы .NET Framework 4.5, а также среды Visual Studio 2012 и C# 5.0.', '2018 год');

-- Заполним таблицу посредник "КнигиЖанры". Тем самым присвоим книгам жанры.
INSERT INTO BooksGenres
VALUES 
	(1, 1),
	(1, 3),
	(2, 4),
	(3, 3),
	(4, 1),
	(5, 2);

-- Грязно для теста!!!
-- Выведем информацию о книгах, чтобы убедиться в корректности работы связей.
SELECT * FROM Books
JOIN Authors ON Books.AuthorId = Authors.id
JOIN BooksGenres ON BookId = Books.id
JOIN Genres ON GenreId = Genres.id;

-- Создаем таблицу "Экземпляры"
-- Представляет данные об экземплярах книг.
-- Связана с таблицей книг внешним ключом.
CREATE TABLE Copies(
	idCopy INT PRIMARY KEY IDENTITY(1,1),				-- ID Экземпляра
	idBook INT UNIQUE FOREIGN KEY REFERENCES Books(id), -- ID Книги
	Amount INT DEFAULT 0 NOT NULL,						-- Кол-во экземпляров
	AmountFreeCopies INT NOT NULL						-- Кол-во доступных экземпляров
)

-- Заполним таблицу "Экземпляры" для теста
INSERT INTO Copies
VALUES
	(1, 3, 3),
	(2, 1, 1),
	(3, 5, 5),
	(4, 6, 6),
	(5, 4, 4);

-- Выведем книги с информацией об экземплярах
SELECT * FROM Copies
JOIN Books ON idBook = Books.id;

-- Создаем таблицу "Читатели"
-- Содержит информацию о зарегистрированных читателях.
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

-- Заполним таблицу читателей
INSERT INTO Readers
VALUES
	('Федорова','Кристина','Ярославовна', 'KristinaFedorova179', 'Fedorova179@gmail.com', 'nFRLA48bH1AW', '413750, г. Тим, ул. Проектируемый 5217-й проезд, дом 126, квартира 358', '+7 (974) 342-26-38', 'https://randus.org/photos/w/41e37060606764f8.jpg');

-- Создаем таблицу "Библиотекари"
-- Содержит информацию о сотрудниках библиотеки.
CREATE TABLE Librarians(
	id INT PRIMARY KEY IDENTITY(1,1),
	SurnameLibrarian NVARCHAR(255) NOT NULL,
	NameLibrarian NVARCHAR(255) NOT NULL,
	PatronymicLibrarian NVARCHAR(255) NOT NULL,
	CodeLibrarian NVARCHAR(6) UNIQUE NOT NULL
)

-- Заполним таблицу "Библиотекари"
INSERT INTO Librarians
VALUES
	('Библиотекарьев', 'Павел', 'Петрович', '676767'),
	('Агафонова', 'Ирина', 'Ивановна', '231243');

-- Создаем таблицу "Записи о брони"
-- Содержит информацию о всех забронированных экземплярах книг
CREATE TABLE BookingRecords(
	id INT PRIMARY KEY IDENTITY(1,1),
	idReader INT FOREIGN KEY REFERENCES Readers(id),
	idBook INT FOREIGN KEY REFERENCES Books(id),
	BookingDate DATE NOT NULL,
	DateOfCompletion DATE NOT NULL
)

-- Заполним таблицу записей о брони
INSERT INTO BookingRecords
VALUES
	(1, 2, '2021-02-25', '2021-02-28'),
	(1, 4, '2021-02-25', '2021-02-28');

-- Выведем записи о забронированных книгах
SELECT * FROM BookingRecords
JOIN Readers ON idReader = Readers.id
JOIN Books ON idBook = Books.id;

-- Создаем таблицу "Выдачи книг"
-- Хранит записи о выдачах библиотекой экземпляров книг читателям
CREATE TABLE LendingBooks(
	id INT PRIMARY KEY IDENTITY(1,1),
	idLibrarian INT FOREIGN KEY REFERENCES Librarians(id) NOT NULL,
	idCopy INT FOREIGN KEY REFERENCES Copies(idCopy) NOT NULL,
	idReader INT FOREIGN KEY REFERENCES Readers(id) NOT NULL,
	DateOfIssue DATE NOT NULL,
	ExpectedDateOfReturn DATE NOT NULL, 
	ActualReturnDate DATE,
	StatusNode BIT DEFAULT (0) NOT NULL -- статус (книга не/возвращена)
)

-- Создаем таблицу "Полка читателя"
-- Хранит информацию о всех операциях читателя с книгами
-- деля их на категории полок (бронь, прочитано, читаю и тд...)
CREATE TABLE ReadersShelfs(
	id INT PRIMARY KEY IDENTITY(1,1),
	idReader INT FOREIGN KEY REFERENCES Readers(id) NOT NULL,
	idBook INT FOREIGN KEY REFERENCES Books(id) NOT NULL,
	idCategoryShelf INT FOREIGN KEY REFERENCES CategoriesShelfs(id) NOT NULL
)

-- Создаем таблицу "Категории полок"
CREATE TABLE CategoriesShelfs(
	id INT PRIMARY KEY,
	Category NVARCHAR(160) NOT NULL
)

-- Заполним таблицу "Категории полок"
INSERT INTO CategoriesShelfs
VALUES
	(1, 'Прочитано'),
	(2, 'Забронировано'),
	(3, 'Готово к вывозу'),
	(4, 'В процессе чтения');

-- Выведем категории полок для проверки
SELECT * FROM CategoriesShelfs;