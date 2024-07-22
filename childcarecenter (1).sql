-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Май 10 2024 г., 05:40
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `childcarecenter`
--

-- --------------------------------------------------------

--
-- Структура таблицы `children`
--

CREATE TABLE `children` (
  `ID` int(11) NOT NULL,
  `Last_name` varchar(50) DEFAULT NULL,
  `First_name` varchar(50) DEFAULT NULL,
  `Date_of_birth` date DEFAULT NULL,
  `Group` varchar(100) DEFAULT NULL,
  `Contact_info` varchar(100) DEFAULT NULL,
  `Parent_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `children`
--

INSERT INTO `children` (`ID`, `Last_name`, `First_name`, `Date_of_birth`, `Group`, `Contact_info`, `Parent_ID`) VALUES
(1, 'Петров', 'Іван', '2015-03-10', 'Group A', 'телефон: 123456789', 1),
(2, 'Іванова', 'Марія', '2016-05-15', 'Group B', 'email: ivanova@example.com', 2),
(3, 'Сидоров', 'Олег', '2017-07-20', 'Group C', 'телефон: 987654321', 3),
(4, 'Ковальчук', 'Олексій', '2016-09-25', 'Group A', 'email: kovalchuk@example.com', 4),
(5, 'Павленко', 'Анна', '2018-01-05', 'Group B', 'телефон: 555666777', 5),
(6, 'Савченко', 'Віталій', '2017-03-15', 'Group C', 'email: savchenko@example.com', 6),
(7, 'Шевченко', 'Юлія', '2019-04-20', 'Group A', 'телефон: 999888777', 7),
(8, 'Мельник', 'Петро', '2018-06-10', 'Group B', 'email: melnyk@example.com', 8),
(9, 'Ковальов', 'Денис', '2019-08-15', 'Group C', 'телефон: 111222333', 9),
(10, 'Лисенко', 'Олена', '2020-02-25', 'Group B', 'email: lisenko@example.com', 10);

-- --------------------------------------------------------

--
-- Структура таблицы `groups`
--

CREATE TABLE `groups` (
  `ID` int(11) NOT NULL,
  `Group_name` varchar(50) DEFAULT NULL,
  `Age_category` varchar(50) DEFAULT NULL,
  `Teacher_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `parents`
--

CREATE TABLE `parents` (
  `ID` int(11) NOT NULL,
  `Last_name` varchar(50) DEFAULT NULL,
  `First_name` varchar(50) DEFAULT NULL,
  `Contact_info` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `schedule`
--

CREATE TABLE `schedule` (
  `ID` int(11) NOT NULL,
  `Date` varchar(20) DEFAULT NULL,
  `Start_time` time DEFAULT NULL,
  `End_time` time DEFAULT NULL,
  `Teacher_ID` int(11) DEFAULT NULL,
  `Group` varchar(20) DEFAULT NULL,
  `activity` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `schedule`
--

INSERT INTO `schedule` (`ID`, `Date`, `Start_time`, `End_time`, `Teacher_ID`, `Group`, `activity`) VALUES
(1, '2024-05-01', '08:00:00', '10:00:00', 1, 'Group A', 'Activity 1'),
(2, '2024-05-02', '09:00:00', '11:00:00', 2, 'Group B', 'Activity 2'),
(3, '2024-05-03', '10:00:00', '12:00:00', 3, 'Group C', 'Activity 3'),
(4, '2024-05-04', '11:00:00', '13:00:00', 4, 'Group A', 'Activity 4'),
(5, '2024-05-05', '12:00:00', '14:00:00', 5, 'Group B', 'Activity 5'),
(6, '2024-05-06', '13:00:00', '15:00:00', 6, 'Group C', 'Activity 6'),
(7, '2024-05-07', '14:00:00', '16:00:00', 7, 'Group A', 'Activity 7'),
(8, '2024-05-08', '15:00:00', '17:00:00', 8, 'Group B', 'Activity 8');

-- --------------------------------------------------------

--
-- Структура таблицы `teachers`
--

CREATE TABLE `teachers` (
  `ID` int(11) NOT NULL,
  `Last_name` varchar(50) DEFAULT NULL,
  `First_name` varchar(50) DEFAULT NULL,
  `Position` varchar(50) DEFAULT NULL,
  `Contact_info` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `teachers`
--

INSERT INTO `teachers` (`ID`, `Last_name`, `First_name`, `Position`, `Contact_info`) VALUES
(3, 'Петров', 'Петр', 'Викладач фізикb', 'teacher@mail.com');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `Login` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`ID`, `Login`, `Password`) VALUES
(8, '4444', '131231'),
(9, '45', '53'),
(10, '55', '55555'),
(11, '3ф', 'ф'),
(12, '21321', '213123'),
(13, '1312321', '12123123'),
(14, 'ак', 'ываыва'),
(15, '323', ''),
(16, '232323', '2323'),
(17, '123', '213'),
(18, '3', '3'),
(19, '3', '3323'),
(20, '1', '1'),
(21, '5', '5');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `children`
--
ALTER TABLE `children`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `groups`
--
ALTER TABLE `groups`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `parents`
--
ALTER TABLE `parents`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `children`
--
ALTER TABLE `children`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `groups`
--
ALTER TABLE `groups`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `parents`
--
ALTER TABLE `parents`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `schedule`
--
ALTER TABLE `schedule`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `teachers`
--
ALTER TABLE `teachers`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
