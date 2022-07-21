-- CREATE TABLE IF NOT EXISTS accounts(

--   id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',

--   createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',

--   updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',

--   name varchar(255) COMMENT 'User Name',

--   email varchar(255) COMMENT 'User Email',

--   picture varchar(255) COMMENT 'User Picture'

-- ) default charset utf8 COMMENT '';

-- CREATE TABLE

--     profiles (

--         id VARCHAR(255) NOT NULL,

--         email VARCHAR(255) NOT NULL,

--         name VARCHAR(255),

--         picture VARCHAR(255),

--         watchlist VARCHAR(255),

--         PRIMARY KEY (id)

--     );

CREATE TABLE
    IF NOT EXISTS towerEvents(
        id INT NOT NULL AUTO_INCREMENT,
        creatorId VARCHAR(255) NOT NULL,
        title VARCHAR(255) NOT NULL,
        description VARCHAR(255),
        imageURL VARCHAR(255),
        tickets INT NOT NULL,
        type ENUM(
            'concert',
            'expo',
            'con',
            'exhibit',
            'sports',
            'digital'
        ) DEFAULT 'concert',
        location VARCHAR(255),
        price INT NOT NULL,
        status ENUM(
            'forSale',
            'limited',
            'canceled',
            'soldOut'
        ),
        startDate DATE,
        endDate DATE,
        PRIMARY KEY (id),
        FOREIGN KEY (creatorId) REFERENCES profiles (id)
    );

-- DROP TABLE `towerEvents`