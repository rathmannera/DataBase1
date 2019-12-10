create table if not exists Concert
(
	concert_id int auto_increment
		primary key,
	city varchar(50) not null,
	venue varchar(50) null,
	country varchar(50) not null,
	year int not null,
	state varchar(2) null
);

create table if not exists Genre
(
	genre_id int auto_increment
		primary key,
	genre varchar(20) not null
);

create table if not exists Label
(
	label_id int auto_increment
		primary key,
	label_name varchar(50) not null
);

create table if not exists Album
(
	album_id int auto_increment
		primary key,
	album_name varchar(50) not null,
	release_date date null,
	num_tracks int default 1 not null,
	label_id int not null,
	live_recording tinyint(1) default 0 not null,
	constraint Album_Label_label_id_fk
		foreign key (label_id) references Label (label_id)
);

create table if not exists Artist
(
	artist_id int auto_increment
		primary key,
	artist_name varchar(50) not null,
	label_id int not null,
	constraint Artist_Label_label_id_fk
		foreign key (label_id) references Label (label_id)
);

create table if not exists Artist_album
(
	artist_album_id int auto_increment
		primary key,
	artist_id int not null,
	album_id int not null,
	constraint Artist_album_Album_album_id_fk
		foreign key (album_id) references Album (album_id)
		on delete cascade,
	constraint Artist_album_Artist_artist_id_fk
		foreign key (artist_id) references Artist (artist_id)
		on delete cascade
);

create table if not exists Artist_concert
(
	artist_concert_id int auto_increment
		primary key,
	artist_id int not null,
	concert_id int not null,
	constraint Artist_concert_Artist_artist_id_fk
		foreign key (artist_id) references Artist (artist_id)
		on delete cascade,
	constraint Artist_concert_Concert_concert_id_fk
		foreign key (concert_id) references Concert (concert_id)
		on delete cascade
);

create table if not exists Group_member
(
	group_member_id int auto_increment
		primary key,
	member_name varchar(50) not null,
	artist_id int not null,
	constraint Group_member_Artist_artist_id_fk
		foreign key (artist_id) references Artist (artist_id)
);

create table if not exists Playlist
(
	playlist_id int auto_increment
		primary key,
	playlist_name varchar(50) not null
);

create table if not exists Song
(
	song_id int auto_increment
		primary key,
	artist_id int not null,
	genre_id int not null,
	lyrics text null,
	song_name varchar(70) not null,
	length time not null,
	constraint Song_Artist_artist_id_fk
		foreign key (artist_id) references Artist (artist_id),
	constraint Song_Genre_genre_id_fk
		foreign key (genre_id) references Genre (genre_id)
);

create table if not exists Song_album
(
	song_album_id int auto_increment
		primary key,
	song_id int not null,
	album_id int not null,
	constraint Song_album_Album_album_id_fk
		foreign key (album_id) references Album (album_id)
		on delete cascade,
	constraint Song_album_Song_song_id_fk
		foreign key (song_id) references Song (song_id)
		on delete cascade
);

create table if not exists Song_concert
(
	song_concert_id int auto_increment
		primary key,
	song_id int not null,
	concert_id int not null,
	constraint Song_concert_Concert_concert_id_fk
		foreign key (concert_id) references Concert (concert_id)
		on delete cascade,
	constraint Song_concert_Song_song_id_fk
		foreign key (song_id) references Song (song_id)
		on delete cascade
);

create table if not exists Song_playlist
(
	song_playlist_id int auto_increment
		primary key,
	song_id int not null,
	playlist_id int not null,
	constraint Song_playlist_Playlist_playlist_id_fk
		foreign key (playlist_id) references Playlist (playlist_id)
		on delete cascade,
	constraint Song_playlist_Song_song_id_fk
		foreign key (song_id) references Song (song_id)
		on delete cascade
);
