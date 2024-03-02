DROP DATABASE IF EXISTS `app_db`;
CREATE DATABASE `app_db`;
USE `app_db`;

CREATE TABLE `users` (
    `userId` int AUTO_INCREMENT NOT NULL,
    `userName` varchar(255) NOT NULL,
    `email` varchar(255) NOT NULL,
    `password` varchar(255) NOT NULL,
    `phonenumber` varchar(255) NOT NULL,
    `gender` varchar(255) NOT NULL,
    `age` int NOT NULL,
    PRIMARY KEY (`userId`)
);
INSERT INTO users (userName, email, password, phonenumber, gender, age)
VALUES
    ('JohnDoe', 'john.doe@gmail.com', 'password123', '123-456-7890', 'Male', 20),
    ('JaneSmith', 'jane.smith@gmail.com', 'password456', '987-654-3210', 'Female', 21),
    ('AliceJohnson', 'alice.johnson@gmail.com', 'pass123', '555-123-4567', 'Female', 22),
    ('BobWilliams', 'bob.williams@gmail.com', 'securepass', '111-222-3333', 'Male', 23),
    ('EvaBrown', 'eva.brown@gmail.com', 'mysecret', '999-888-7777', 'Female', 24),
    ('CharlieDavis', 'charlie.davis@gmail.com', 'letmein', '444-555-6666', 'Male', 25),
    ('GraceJones', 'grace.jones@gmail.com', 'open123', '777-888-9999', 'Female', 26),
    ('HenryMiller', 'henry.miller@gmail.com', 'hello123', '666-555-4444', 'Male', 27),
    ('LindaWhite', 'linda.white@gmail.com', 'password789', '333-222-1111', 'Female', 28),
    ('SamAnderson', 'sam.anderson@gmail.com', 'secret123', '999-111-2222', 'Male', 29);

CREATE TABLE `posts` (
    `postId` int AUTO_INCREMENT NOT NULL,
    `userId` int NOT NULL,
    `title` varchar(255) NOT NULL,
    `content` varchar(1024) NOT NULL,
    `timestamp` TIMESTAMP NOT NULL,
    `likes` int,
    `tags` varchar(255),
    PRIMARY KEY (`postId`)
);
INSERT INTO posts (userId, title, content, timestamp, likes, tags)
VALUES
(1, 'First Post', 'This is the content of the first post.', '2023-12-12 08:00:00', 15, 'tag1,tag2'),
(2, 'Second Post', 'This is the content of the second post.', '2023-12-12 09:30:00', 20, 'tag3,tag4'),
(3, 'Third Post', 'This is the content of the third post.', '2023-12-12 11:15:00', 10, 'tag5,tag6'),
(4, 'Fourth Post', 'This is the content of the fourth post.', '2023-12-12 13:45:00', 25, 'tag7,tag8'),
(5, 'Fifth Post', 'This is the content of the fifth post.', '2023-12-12 15:00:00', 18, 'tag9,tag10'),
(6, 'Sixth Post', 'This is the content of the sixth post.', '2023-12-12 16:45:00', 12, 'tag11,tag12'),
(7, 'Seventh Post', 'This is the content of the seventh post.', '2023-12-12 18:30:00', 30, 'tag13,tag14'),
(8, 'Eighth Post', 'This is the content of the eighth post.', '2023-12-12 20:00:00', 22, 'tag15,tag16'),
(9, 'Ninth Post', 'This is the content of the ninth post.', '2023-12-12 21:45:00', 17, 'tag17,tag18'),
(10, 'Tenth Post', 'This is the content of the tenth post.', '2023-12-12 23:15:00', 14, 'tag19,tag20'),
(1, 'Eleventh Post', 'This is the content of the eleventh post.', '2023-12-13 08:30:00', 19, 'tag21,tag22'),
(2, 'Twelfth Post', 'This is the content of the twelfth post.', '2023-12-13 10:00:00', 24, 'tag23,tag24'),
(3, 'Thirteenth Post', 'This is the content of the thirteenth post.', '2023-12-13 11:45:00', 16, 'tag25,tag26'),
(4, 'Fourteenth Post', 'This is the content of the fourteenth post.', '2023-12-13 13:15:00', 28, 'tag27,tag28'),
(5, 'Fifteenth Post', 'This is the content of the fifteenth post.', '2023-12-13 14:30:00', 21, 'tag29,tag30'),
(6, 'Sixteenth Post', 'This is the content of the sixteenth post.', '2023-12-13 16:15:00', 13, 'tag31,tag32'),
(7, 'Seventeenth Post', 'This is the content of the seventeenth post.', '2023-12-13 18:00:00', 32, 'tag33,tag34'),
(8, 'Eighteenth Post', 'This is the content of the eighteenth post.', '2023-12-13 19:30:00', 26, 'tag35,tag36'),
(9, 'Nineteenth Post', 'This is the content of the nineteenth post.', '2023-12-13 21:15:00', 18, 'tag37,tag38'),
(10, 'Twentieth Post', 'This is the content of the twentieth post.', '2023-12-13 22:45:00', 15, 'tag39,tag40'),
(1, 'Twenty-First Post', 'This is the content of the twenty-first post.', '2023-12-14 08:45:00', 14, 'tag41,tag42'),
(2, 'Twenty-Second Post', 'This is the content of the twenty-second post.', '2023-12-14 10:15:00', 19, 'tag43,tag44'),
(3, 'Twenty-Third Post', 'This is the content of the twenty-third post.', '2023-12-14 11:45:00', 23, 'tag45,tag46'),
(4, 'Twenty-Fourth Post', 'This is the content of the twenty-fourth post.', '2023-12-14 13:30:00', 27, 'tag47,tag48'),
(5, 'Twenty-Fifth Post', 'This is the content of the twenty-fifth post.', '2023-12-14 15:00:00', 31, 'tag49,tag50'),
(6, 'Twenty-Sixth Post', 'This is the content of the twenty-sixth post.', '2023-12-14 16:45:00', 20, 'tag51,tag52'),
(7, 'Twenty-Seventh Post', 'This is the content of the twenty-seventh post.', '2023-12-14 18:30:00', 15, 'tag53,tag54'),
(8, 'Twenty-Eighth Post', 'This is the content of the twenty-eighth post.', '2023-12-14 20:00:00', 22, 'tag55,tag56'),
(9, 'Twenty-Ninth Post', 'This is the content of the twenty-ninth post.', '2023-12-14 21:45:00', 17, 'tag57,tag58'),
(10, 'Thirtieth Post', 'This is the content of the thirtieth post.', '2023-12-14 23:15:00', 14, 'tag59,tag60');

CREATE TABLE `comments` (
    `commentId` int AUTO_INCREMENT NOT NULL,
    `userId` int NOT NULL,
    `postId` int NOT NULL,
    `content` varchar(1024),
    `timestamp` TIMESTAMP NOT NULL,
    PRIMARY KEY (`commentId`)
);
INSERT INTO comments (userId, postId, content, timestamp)
VALUES
    (1, 1, 'Great post! I really enjoyed reading it.', '2023-12-12 08:30:00'),
    (2, 1, 'Interesting insights. Looking forward to more!', '2023-12-12 09:15:00'),
    (3, 2, 'Nice content. Keep up the good work!', '2023-12-12 10:45:00'),
    (4, 3, 'I have a question about this post. Can you elaborate?', '2023-12-12 12:00:00'),
    (5, 3, 'Sure thing! What would you like to know?', '2023-12-12 13:30:00'),
    (6, 4, 'This post resonates with me. Thanks for sharing.', '2023-12-12 15:00:00'),
    (7, 5, 'I completely agree with your points in this post.', '2023-12-12 16:15:00'),
    (8, 6, 'Looking forward to more posts from you!', '2023-12-12 17:45:00'),
    (9, 7, 'I found this post very informative. Well done!', '2023-12-12 19:00:00'),
    (10, 8, 'Excellent writing. Keep it up!', '2023-12-12 20:30:00'),
    (1, 9, 'This post is fantastic! I appreciate your perspective.', '2023-12-13 08:30:00'),
    (2, 9, 'Well written! I learned something new from this post.', '2023-12-13 09:15:00'),
    (3, 10, 'I can relate to the content of this post. Great job!', '2023-12-13 10:45:00'),
    (4, 1, 'Your first post inspired me to share my thoughts. Thank you!', '2023-12-13 12:00:00'),
    (5, 2, 'The second post is even better than the first. Keep it up!', '2023-12-13 13:30:00'),
    (6, 3, 'I have a different perspective on the third post. Let\'s discuss!', '2023-12-13 15:00:00'),
    (7, 4, 'The fourth post made me think deeply. Well done!', '2023-12-13 16:15:00'),
    (8, 5, 'I appreciate the insights shared in the fifth post.', '2023-12-13 17:45:00'),
    (9, 6, 'Sixth post resonated with me. Looking forward to more content.', '2023-12-13 19:00:00'),
    (10, 7, 'The seventh post is a masterpiece. Thank you for sharing!', '2023-12-13 20:30:00'),
    (1, 8, 'Eighth post was enlightening. I have some questions for discussion.', '2023-12-13 08:30:00'),
    (2, 9, 'The ninth post is thought-provoking. Let\'s exchange ideas!', '2023-12-13 09:15:00'),
    (3, 10, 'The tenth post touched on important points. Well articulated!', '2023-12-13 10:45:00'),
    (4, 1, 'I can\'t get enough of the first post. It\'s amazing!', '2023-12-13 12:00:00'),
    (5, 2, 'Second post resonated with me deeply. Thank you for sharing.', '2023-12-13 13:30:00'),
    (6, 3, 'The third post has sparked some interesting thoughts. Let\'s discuss!', '2023-12-13 15:00:00'),
    (7, 4, 'Fourth post deserves all the likes. Great content!', '2023-12-13 16:15:00'),
    (8, 5, 'I agree with the points made in the fifth post. Well argued!', '2023-12-13 17:45:00'),
    (9, 6, 'Sixth post is a gem. Looking forward to more insights!', '2023-12-13 19:00:00'),
    (10, 7, 'Seventh post is a must-read. Thanks for sharing your knowledge!', '2023-12-13 20:30:00');

CREATE TABLE `likedPosts` (
    userId int,
    postId int
);
INSERT INTO likedPosts (userId, postId)
VALUES
    (1, 3),
    (2, 7),
    (3, 10),
    (4, 2),
    (5, 5),
    (6, 8),
    (7, 1),
    (8, 6),
    (9, 9),
    (10, 4),
    (1, 13),
    (2, 17),
    (3, 20),
    (4, 12),
    (5, 15),
    (6, 18),
    (7, 11),
    (8, 16),
    (9, 19),
    (10, 14),
    (1, 23),
    (2, 27),
    (3, 30),
    (4, 22),
    (5, 25),
    (6, 28),
    (7, 21),
    (8, 26),
    (9, 29),
    (10, 24);

CREATE TABLE `friendRequests` (
    userId int,
    friendId int
);
    
CREATE TABLE `pendingRequests` (
    userId int,
    friendId int
);

CREATE TABLE `friends` (
    userId int,
    friendId int
);
INSERT INTO friends (userId, friendId)
VALUES
    (9, 5),
    (5, 9),

    (9, 2),
    (2, 9),

    (5, 2),
    (2, 5),

    (5, 4),
    (4, 5),

    (5, 8),
    (8, 5),

    (8, 3),
    (3, 8);