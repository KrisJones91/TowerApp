-- CREATE TABLE IF NOT EXISTS accounts(

--   id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',

--   createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',

--   updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',

--   name varchar(255) COMMENT 'User Name',

--   email varchar(255) COMMENT 'User Email',

--   picture varchar(255) COMMENT 'User Picture'

-- ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS towerEvents(
        id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
        title VARCHAR(255),
        description VARCHAR(255),
        imageURl VARCHAR(255),
        tickets INT NOT NULL,
        type ENUM(
            'concert',
            'expo',
            'con',
            'exhibit',
            'sports',
            'digital'
        ) DEFAULT 'concert',
        status ENUM(
            'forSale',
            'limited',
            'canceled',
            'soldOut'
        ),
        location VARCHAR(255),
        price INT NOT NULL,
        startDate DATE,
        endDate DATE
    );