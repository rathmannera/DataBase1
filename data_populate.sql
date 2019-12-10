
INSERT INTO Genre (genre_id, genre) VALUES (1, 'Alternate');
INSERT INTO Genre (genre_id, genre) VALUES (2, 'Blues');
INSERT INTO Genre (genre_id, genre) VALUES (3, 'Classical');
INSERT INTO Genre (genre_id, genre) VALUES (4, 'Country');
INSERT INTO Genre (genre_id, genre) VALUES (5, 'Dance');
INSERT INTO Genre (genre_id, genre) VALUES (6, 'Electronic');
INSERT INTO Genre (genre_id, genre) VALUES (7, 'Hip-Hop/Rap');
INSERT INTO Genre (genre_id, genre) VALUES (8, 'Jazz');
INSERT INTO Genre (genre_id, genre) VALUES (9, 'Pop');
INSERT INTO Genre (genre_id, genre) VALUES (10, 'R&B/Soul');
INSERT INTO Genre (genre_id, genre) VALUES (11, 'Rock');
INSERT INTO Genre (genre_id, genre) VALUES (12, 'soundtrack');


INSERT INTO Label (label_id, label_name) VALUES (1, 'RoadRunner Records');
INSERT INTO Label (label_id, label_name) VALUES (2, 'Cactus Jack Records');
INSERT INTO Label (label_id, label_name) VALUES (3, 'Rostrum Records');
INSERT INTO Label (label_id, label_name) VALUES (4, 'Dreamville');
INSERT INTO Label (label_id, label_name) VALUES (5, 'Republic Records');
INSERT INTO Label (label_id, label_name) VALUES (6, 'Columbia Records');
INSERT INTO Label (label_id, label_name) VALUES (7, 'Syco Music');
INSERT INTO Label (label_id, label_name) VALUES (8, 'RCA Records');
INSERT INTO Label (label_id, label_name) VALUES (9, 'Warner Bros.');
INSERT INTO Label (label_id, label_name) VALUES (10, 'Warner Records');
INSERT INTO Label (label_id, label_name) VALUES (11, 'REMember Music');
INSERT INTO Label (label_id, label_name) VALUES (12, 'Sony Music Entertainment');
INSERT INTO Label (label_id, label_name) VALUES (13, 'Epic Records');
INSERT INTO Label (label_id, label_name) VALUES (14, 'NONE');
INSERT INTO Label (label_id, label_name) VALUES (15, 'Big Machine Records');

INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (1, 'Porcupine Tree', 1);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (2, 'Travis Scott', 2);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (3, 'Mac Miller', 3);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (4, 'J. Cole', 4);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (5, 'Post Malone', 5);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (6, 'Chance The Rapper', 8);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (7, 'Russ', 6);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (8, 'Childish Gambino', 8);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (9, 'Metro Boomin', 5);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (10, 'Camila Cabello', 7);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (11, 'Khalid', 8);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (12, 'Johnny Cash', 6);
INSERT INTO Artist (artist_id, artist_name, label_id) VALUES (13, 'Taylor Swift', 15);

INSERT INTO Group_member (group_member_id, member_name, artist_id) VALUES (1, 'Steven Wilson', 1);
INSERT INTO Group_member (group_member_id, member_name, artist_id) VALUES (2, 'Richard Barbieri', 1);
INSERT INTO Group_member (group_member_id, member_name, artist_id) VALUES (3, 'Colin Edwin', 1);
INSERT INTO Group_member (group_member_id, member_name, artist_id) VALUES (4, 'Gavin Herrison', 1);

INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (1, 'Anesthetize', '2010-05-20', 19, 1, 1);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (2, 'Astroworld', '2018-08-03', 17, 2, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (3, 'Swimming', '2018-08-03', 13, 10, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (4, 'At Folsom Prison', '1968-01-03', 16, 12, 1);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (5, 'American Teen', '2017-03-03', 15, 8, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (6, 'Rodeo', '2015-09-04', 16, 13, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (7, 'Birds in the Trap sing McKnight', '2016-09-02', 14, 13, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (8, 'Highest in the Room - Single', '2019-10-04', 1, 2, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (9, 'Upper Echelon (feat. T.I. & 2 Chainz - Single)', '2013-05-21', 1, 13, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (10, 'There''s Really A Wolf', '2016-05-05', 20, 6, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (11, 'NOT ALL HEROES WEAR CAPES', '2018-11-02', 13, 5, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (12, 'Stoney (Deluxe)', '2016-12-09', 18, 5, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (13, 'KOD', '2018-04-20', 12, 4, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (14, 'The Big Day', '2019-04-20', 22, 14, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (15, 'This Is America - Single', '2018-05-05', 1, 8, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (16, 'Reputation', '2017-11-10', 15, 15, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (17, '1989', '2014-10-27', 13, 15, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (18, 'Easy - Single', '2019-10-11', 1, 13, 0);
INSERT INTO Album (album_id, album_name, release_date, num_tracks, label_id, live_recording) VALUES (19, 'Free Spirit', '2019-04-05', 17, 8, 0);

INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (1, 1, 11, '', 'Into', '00:02:07');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (2, 1, 11, 'Sunlight coming through the haze
No gaps in the blind
To let it inside
The bed is unmade
Some music still plays
TV, yeah it''s always on
A flicker on the screen
A movie actress screams
I''m basking in the shit flowing out of it
I''m stoned in the mall again
Terminally bored
Shuffling round the stores
And shoplifting is getting so last year''s thing
Xbox is a god to me
A finger on the switch
My mother is a bitch
My father gave up ever trying to talk to me
Don''t try engaging me
The vaguest of shrugs
The prescription drugs
You''ll never find
a person inside
My face is mogadon
Curiosity
has given up on me
I''m tuning out desires
The pills are on the rise
How can I be sure I''m here?
The pills that I''ve been taking confuse me
I need to know that someone sees that
There''s nothing left, I simply am not here
I''m through with pornography
The acting is lame
The action is tame
Explicitly dull
Arousal annulled
Your mouth should be boarded up
Talking all day
With nothing to say
Your shallow proclamations
All misinformation
My friend says he wants to die
He''s in a band
They sound like Pearl Jam
The clothes are all black
The music is crap
In school I don''t concentrate
And sex is kinda fun,
but just another one
of all the empty ways
of using up a day
How can I be sure I''m here?
The pills that I''ve been taking confuse me
I need to know that someone sees that
There''s nothing left, I simply am not here
Bipolar disorder
Can''t deal with the boredom
Bipolar disorder
Can''t deal with the boredom
You don''t try to be liked
You don''t mind
You feel no sun
You steal a gun
To kill time
You''re somewhere, you''re nowhere
You don''t care
You catch the breeze
You still the leaves
So now where?', 'Fear of a Blank Planet', '00:07:34');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (3, 1, 11, 'All the things that I needed
I wasted my chances
I have found myself wanting
When a mother and father
Gave me their problems
I accepted them all
Nothing ever expected
I was rejected
But I came back for more
And my ashes drift beneath the silver sky
Where a boy rides on a bike and never smiles
And my ashes fall over all the things we''ve said
On a box of photographs under the bed
I will stay in my own world
Under the covers
I will feel safe inside
The kiss that will burn me
Cure me of dreaming
I was always returning
And my ashes find a way beyond the fog
And return to save the child that I forgot
And my ashes fade among the things unseen
And a dream plays in reverse on piano keys
And my ashes drop upon a park in Wales', 'My Ashes', '00:04:46');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (4, 1, 11, 'A good impression of myself
Not much to conceal
I''m saying nothing
But I''m saying nothing revealed
I simply am not here
No way I should appear happy
Stop whining please
Because of who we are
We react in mock surprise
The curse off, there must be more
So don''t breathe here
Don''t leave your bags
I simply am not here
No way I should appear happy
Stop whining please
The dust in my soul
Makes me feel awake in my legs
My head in the clouds
And I''m zoning out
I''m watching TV
But I find it hard to stay conscious
I''m totally bored
But I can''t switch off
Only apathy from the pills in me
Its all in me, all in you
Electricity from the pills in me
Its all in me, all in you
Only eMpTV, cod philosophy
We''re lost in the mall
Shuffling through the stores like zombies
What is the point
What can money buy
My hand''s on a gun
And I find the range, God, tempt me
What did you say
Think I''m passing out
Only apathy from the pills in me
Its all in me, all in you
Electricity from the pills in me
Its all in me, all in you
Only eMpTV, cod philosophy
All the apathy from the pills in me
Its all in me, all in you
Electricity from the pills in me
Its all in me, all in you
Water so warm that day (water so warm that day)
I counted out the waves (I counted out the waves)
As they broke into
The water so warm that day
I was counting out the waves
And I followed their short life
As they broke on the shoreline
I could see you
But I couldn''t hear you
You were holding your hat in the breeze
Turning away from me in this moment
You were stolen as black across the sun
Water so warm that day (water so warm that day)
I counted out the waves (I counted out the waves)
As they broke into shore (as they broke into shore)', 'Anesthetize', '00:17:20');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (5, 1, 11, 'Never want to be old
And I don''t want dependence
It''s no fun to be told
That you can''t blame your parents anymore
I''m finding it hard
To hang from a star
Don''t want to be
Never want to be old
Sullen and bored the kids stay
And in this way they wish away each day?
Stoned in the mall the kids play
And in this way wish away each day?
I don''t really know
If I care what is normal
And I''m not really sure
If the pills I''ve been taking are helping
I''m wasting my life
Hurting inside
I don''t really know
And I''m not really sure
Sullen and bored the kids stay
And in this way they wish away each day?
Stoned in the mall the kids play
And in this way wish away each day?
Sullen and bored the kids stay
And in this way they wish away each day?
Stoned in the mall the kids play
And in this way wish away each day?', 'Sentimental', '00:05:18');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (6, 1, 11, 'Out at the train tracks
I dream of escape
But a song comes onto my iPod
And I realize it''s getting late
And I can''t take the staring
And the sympathy
And I don''t like the questions How do you feel?
How''s it going in school?
And Do you wanna talk about it?
Way out
Way out of here
Fade out
Fade out, vanish
And I''m trying to forget you
And I know that I will
In a thousand years, or maybe a week
Burn all your pictures, and cut out your face
The shutters are down and the curtains are closed
And I''ve covered my tracks
Disposed of the car
Trying to forget even your name and the way that you look
When you''re sleeping
Dreaming of this
Way out
Way out of here
Fade out
Fade out, vanish', 'Way Out of Here', '00:07:47');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (7, 1, 11, 'This means out
This is your way out
Do or drown
Do or drown in torpor
Leave no trace
All my files erased
Burn my clothes
Burn my Prada trainers
Let''s sleep together right now
Relieve the pressure somehow
Switch off the future right now
Let''s sleep forever
This is fate
This is your escape
Leave here now
Leave here, now it''s over
Let''s sleep together right now
Relieve the pressure somehow
Switch off the future right now
Let''s sleep forever', 'Sleep Together', '00:07:54');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (8, 1, 11, 'I don''t know whose side I''m on
I don''t think that I belong round here
If I left the stage would that be wrong ?
I tried to find myself a better way
I got religion but I went astray
They took my money and I lost my faith
Rain keeps crawling down the glass
The good times never seem to last
Close your eyes and let the thought pass
I tried the capsule and I tried the smoke
I tried to aid escape like normal folk
But I never seemed to get the joke
These are my old clothes
This is a new low
This is my blood flow
This is my headstone
I spend my days with all my friends
They''re the ones on who my life depends
I''m gonna miss them when the series ends
Rain keeps crawling down the glass
(Pull yourself together)
The good times never seem to last
(You know it''s not so bad)
Close your eyes and let the thought pass
(Close your eyes and let it pass)', 'Prodigal', '00:06:03');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (9, 1, 11, 'So I got all these things, but so what?
In the end you can''t take them with you
You think you can save my soul? Well OK
Tell me, with all your conviction
What happens now?
What happens now?
Well I could be boarding an aircraft
With a bomb concealed in somebody''s briefcase
And my body will spread through the heavens, across the sky
And my ashes will fall through the cloudburst
What happens now?
What happens now?
What happens now?
What happens now?', 'What Happens Now?', '00:08:09');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (10, 1, 11, 'Here is my car, my phone and my TV
I''ve got it all, but you can see through me
But am I here? It''s kind of hard to tell
I do a good impression of myself
But what''s normal now anyhow?
Sullen and bored the kids stay
And in this way wish away each day
Stoned in the mall the kids play
And in this way wish away each day
Prescription drugs, they help me through the day
And that restraining order keeps me well at bay
And what''s normal now, anyway?
Sullen and bored the kids stay
And in this way wish away each day
Stoned in the mall the kids play
And in this way wish away each day
Sullen and bored the kids stay
And in this way wish away each day
Stoned in the mall the kids play
And in this way wish away each day
Wish I was old and a little sentimental
Wish I was old and a little sentimental
Wish I was old and a little sentimental
Wish I was old and a little sentimental
Wish I was old and a little sentimental
Wish I was old and a little sentimental
Wish I was old and a little sentimental
Wish I was old and a little sentimental
Wish I was old and a little sentimental
Wish I was old and a little sentimental
Wish I was old and a little sentimental
Wish I was old and a little', 'Normal', '00:07:13');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (11, 1, 11, 'Inside the vehicle the cold is extreme
Smoke in my throat kicks me out of my dream
I try to relax but its warmer outside
I fail to connect, it''s a tragic divide
This has become a full time career
To die young would take only 21 years
Gun down a school or blow up a car
The media circus will make you a star
Dark matter flowing out on to a tape
Is only as loud as the silence it breaks
Most things decay in a matter of days
The product is sold the memory fades
Crushed like a rose
In the river flow
I am I know', 'Dark Matter', '00:08:57');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (12, 1, 11, 'Lying through my teeth again
I''ve been bad again, black lies
Skirting round the truth again
To escape the look in your eyes
Cover up the facts again
With the money men, disguise
Losing my integrity
Well it''s lost to me, I don''t mind
Feel my soul going
Feel my soul colder
Blackening my soul again
With another lie, it''s my style
Burying my face again
God I''m so ashamed, this time
Feel my soul going
Feel my soul colder
Feel my soul going
Feel my soul colder', 'Cheating the Polygraph', '00:08:11');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (13, 1, 11, 'Such a pale light
Such a long night
Pick up that key
Don''t drop your gaze in your coffee
Is it me?
Do I look beautiful in the half light?
It''s been so long
Years have gone
Since I belonged
Hold me please
Stay with me
And I will sleep
I will go now
But I will be with you
Hold my gaze
Hold me inside you', 'Half-Light', '00:05:28');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (14, 1, 11, 'Telepath Carbon trapped under stone
Brother mother pale body is thrown
Only way I know to have fun
Fill up my blood, my veins, my lungs
ESP city, rainy and blue
Burn down this town, I give it to you
Aero shallow, photograph blind
Stage fright, black light, coma divine
No sense of time
Sever tomorrow
Exitless mind, ESP Sever tomorrow
School out invective, losing my voice
Film shredding on in multiple choice
America calls, I must go
Oprah savior, I feel that low', 'Sever', '00:05:37');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (15, 1, 11, '', 'Wedding Nails', '00:05:43');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (16, 1, 11, 'This is my home, this is my own, we don''t like no strangers
Raise the kids good, beat the kids good and tie them up
Spread it wide, my wife, my life, push the camera deeper
I can use, I abuse, my muse, I made them all
This machine
Is there to please
Strip the soul
Fill the hole
A fire to feed
A belt to bleed
Strip the soul
Kill them all
They are not gone, they are not gone, they are only sleeping
In graves, in ways, in clay, underneath the floor
Building walls, overalls, getting bored, I got faulty wiring
Brick it up now, brick it up now, but keep the bones
This machine
Is there to please
Strip the soul
Fill the hole
A fire to feed
(Do you want a western home in the rubble?)
A belt to bleed
Strip the soul
Kill them all
(Do you want a western home in the rubble?)
This machine
Is there to please
Strip the soul
Fill the hole
This machine
Is there to please
Strip the soul
Fill the hole
This machine
Is there to please
Strip the soul
Fill the hole
This machine
Is there to please
Strip the soul
Fill the hole
Strip the soul
Fill the hole
Strip the soul
Fill the hole
Black the sky, weapons fly
Lay them waste for your race', 'Strip the Soul / .3', '00:08:17');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (17, 1, 11, 'At the age of sixteen
I grew out of hope
I regarded the cosmos
Through a circle of rope
So I threw out my plans
Ran on to the wheel
And emptied my head
Of all childish ideals
The sleep of no feeling
I married the first girl
Who wasn''t a man
And smiled as the spiders
Ran all over my hands
Made a good living
By dying it''s true
As the world in my TV
Leaked onto my shoes', 'The Sleep of No Dreaming', '00:05:31');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (18, 1, 11, 'God is in my fingers
God is in my head
God is in the trigger
God is in the lead.
God is freedom
God is truth
God is power
God is proof
God is fashion
God is fame
God gives meaning
God gives pain
You can be right like me
We''ve got it all
Your righteous soul
I''ve got a halo ''round me
I''ve got a halo ''round me
I''m not the same as you
Cause I''ve seen the light
And I''m gaining in height now
I''ve got a halo ''round me
I''ve got a halo ''round me
I''ve got a halo ''round my head
God is on the cell phone
God is on the net
God is in the warning
God is in the threat
God is freedom
God is truth
God is power
God is proof
God is fashion
God is fame
God gives meaning
God gives pain
You can be right like me
We''ve got it all
Your righteous soul
I''ve got a halo ''round me
I''ve got a halo ''round me
I''m not the same as you
Cause I''ve seen the light
And I''m gaining in height now
I''ve got a halo ''round me
I''ve got a halo ''round me
I''ve got a halo ''round my head
You can be right like me
We''ve got it all
Your righteous soul
I''ve got a halo ''round me
I''ve got a halo ''round me
I''m not the same as you
Cause I''ve seen the light
And I''m gaining in height now
I''ve got a halo ''round me
I''ve got a halo ''round me
I''ve got a halo ''round my head
Cause I''ve got a halo ''round my head', 'Halo', '00:08:34');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (19, 2, 7, null, 'STARGAZING', '00:04:33');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (20, 2, 7, null, 'CAROUSEL', '00:03:02');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (21, 2, 7, null, '5% TINT', '00:03:18');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (22, 2, 7, null, 'R.I.P SCREW', '00:03:06');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (23, 2, 7, null, 'STOP TRYING TO BE GOD', '00:05:38');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (24, 2, 7, null, 'NO BYSTANDERS', '00:03:38');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (25, 2, 7, null, 'SKELETONS', '00:02:26');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (26, 2, 7, null, 'WAKE UP', '00:03:52');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (27, 2, 7, null, 'NC-17', '00:02:37');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (28, 2, 7, null, 'ASTROTHUNDER', '00:02:23');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (29, 2, 7, null, 'YOSEMITE', '00:02:30');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (30, 2, 7, null, 'CAN''T  SAY', '00:03:18');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (31, 2, 7, null, 'WHO? WHAT!', '00:02:57');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (32, 2, 7, null, 'BUTTERFLY EFFECT', '00:03:11');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (33, 2, 7, null, 'HOUSTONFORNICATION', '00:03:38');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (34, 2, 7, null, 'COFFEE BEAN', '00:03:29');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (35, 3, 7, null, 'Come Back to Earth', '00:02:42');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (36, 3, 7, null, 'Hurt Feelings', '00:04:06');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (37, 3, 7, null, 'What''s the Use', '00:04:49');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (38, 3, 7, null, 'Perfecto', '00:03:35');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (39, 3, 7, null, 'Self Care', '00:05:45');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (40, 3, 7, null, 'Wings', '00:04:10');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (41, 3, 7, null, 'Ladders', '00:04:47');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (42, 3, 7, null, 'Small Worlds', '00:04:32');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (43, 3, 7, null, 'Conversation', '00:03:30');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (44, 3, 7, null, 'Dunno', '00:03:57');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (45, 3, 7, null, 'Jet Fuel', '00:05:45');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (46, 3, 7, null, '2009', '00:05:48');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (47, 3, 7, null, 'So It Goes', '00:05:13');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (48, 11, 10, null, 'American Teen', '00:04:10');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (49, 11, 10, null, 'Young Dumb & Broke', '00:03:22');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (50, 11, 10, null, 'Location', '00:03:39');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (51, 11, 10, null, 'Another Sad Love Song', '00:04:04');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (52, 11, 10, null, 'Saved', '00:03:26');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (53, 11, 10, null, 'Coaster', '00:03:19');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (54, 11, 10, null, '8TEEN', '00:03:48');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (55, 11, 10, null, 'Let''s Go', '00:03:24');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (56, 11, 10, null, 'Hopeless', '00:02:47');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (57, 11, 10, null, 'Cold Blooded', '00:03:27');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (58, 11, 10, null, 'Winter', '00:04:01');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (59, 11, 10, null, 'Therapy', '00:04:17');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (60, 11, 10, null, 'Keep Me', '00:04:36');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (61, 11, 10, null, 'Shot Down', '00:03:27');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (62, 11, 10, null, 'Angels', '00:02:50');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (63, 12, 4, null, 'Folsom Prison Blues (Live)', '00:02:42');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (64, 12, 4, null, 'Dark As the Dungeon (Live)', '00:03:07');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (65, 12, 4, null, 'I Still Miss Someone (Live)', '00:01:36');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (66, 12, 4, null, 'Cocaine Blues (Live)', '00:03:03');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (67, 12, 4, null, '25 Minutes to Go (Live)', '00:03:37');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (68, 12, 4, null, 'Orange Blossom Special (Live)', '00:03:01');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (69, 12, 4, null, 'The Long Black Veil (Live)', '00:03:59');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (70, 12, 4, null, 'The Wall (Live)', '00:01:54');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (71, 12, 4, null, 'Dirty Old Egg-Suckin'' (Live)', '00:01:16');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (72, 12, 4, null, 'Jackson (Live)', '00:02:56');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (73, 12, 4, null, 'Give My Love to Rose (Live)', '00:02:42');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (74, 12, 4, null, 'I Got Stripes (Live)', '00:01:45');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (75, 12, 4, null, 'Greystone Chapel (Live)', '00:05:45');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (76, 12, 4, null, 'Green, Green Grass of Home (Live)', '00:03:02');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (77, 12, 4, null, 'Flushed from the Bathroom (Live)', '00:02:41');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (78, 2, 7, null, 'Oh My Dis Side (feat. Quavo)', '00:05:51');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (79, 2, 7, null, '3500 (feat. Future  & 2 Chainz)', '00:07:42');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (80, 2, 7, null, '90210 (feat. Kacy Hill)', '00:05:39');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (81, 2, 7, null, 'Antidote', '00:04:23');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (82, 2, 7, null, 'Pornography', '00:03:51');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (83, 2, 7, null, 'Wasted (feat.  Juicy J)', '00:03:55');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (84, 2, 7, null, 'Pray 4 Love (feat. The Weekend)', '00:05:07');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (85, 2, 7, null, 'Nightcrawler (feat. Swae Lee & Chief Keef)', '00:05:21');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (86, 2, 7, null, 'Piss On Your Grave (feat. Kanye West)', '00:02:46');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (87, 2, 7, null, 'Impossible', '00:04:02');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (88, 2, 7, null, 'Maria I''m drunk (feat. Justin Bieber & Young Thug)', '00:05:49');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (89, 2, 7, null, 'Flying High (feat. Toro y Moi)', '00:03:28');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (90, 2, 7, null, 'I can Tell', '00:03:55');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (91, 2, 7, null, 'Apple Pie', '00:03:39');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (92, 2, 7, null, 'Ok Alright (feat. ScHoolboy Q)', '00:06:57');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (93, 2, 7, null, 'Never Catch Me', '00:02:56');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (94, 2, 7, null, 'the ends', '00:03:21');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (95, 2, 7, null, 'way back', '00:04:32');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (96, 2, 7, null, 'coordinate', '00:03:46');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (97, 2, 7, null, 'through the late night', '00:04:46');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (98, 2, 7, null, 'beibs in the trap', '00:03:33');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (99, 2, 7, null, 'sdp interlude', '00:03:11');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (100, 2, 7, null, 'sweet sweet', '00:03:42');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (101, 2, 7, null, 'outside', '00:02:56');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (102, 2, 7, null, 'goosebumps', '00:04:03');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (103, 2, 7, null, 'first  take', '00:05:13');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (104, 2, 7, null, 'pick up the phone', '00:04:12');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (105, 2, 7, null, 'lose', '00:03:20');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (106, 2, 7, null, 'guidance', '00:03:27');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (107, 2, 7, null, 'wonderful', '00:03:36');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (108, 2, 7, null, 'Highest in the Room', '00:02:56');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (109, 2, 7, null, 'Upper Echelon (feat. T.I. & 2 Chainz)', '00:04:04');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (110, 2, 7, null, 'SICKO MODE', '00:05:13');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (111, 7, 7, null, 'I''m here', '00:04:00');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (112, 7, 7, null, 'The Stakeout', '00:02:51');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (113, 7, 7, null, 'Act Now', '00:03:10');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (114, 7, 7, null, 'Cherry Hill', '00:03:43');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (115, 7, 7, null, 'Me  You', '00:02:44');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (116, 7, 7, null, 'Ride Slow', '00:03:06');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (117, 7, 7, null, 'Don''t Lie', '00:03:08');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (118, 7, 7, null, 'Do It Myself', '00:02:47');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (119, 7, 7, null, 'I Wanna Go Down With You', '00:03:04');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (120, 7, 7, null, 'Family & Friends', '00:02:55');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (121, 7, 7, null, 'What They Want', '00:02:46');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (122, 7, 7, null, 'Got This', '00:02:53');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (123, 7, 7, null, 'No Turning Back', '00:02:35');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (124, 7, 7, null, 'Losin Control', '00:03:58');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (125, 7, 7, null, 'Scared', '00:02:59');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (126, 7, 7, null, 'Back To You', '00:03:28');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (127, 7, 7, null, 'One More Shot', '00:03:12');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (128, 7, 7, null, 'Emergency', '00:03:50');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (129, 7, 7, null, 'Pull The Trigger', '00:02:37');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (130, 7, 7, null, 'MVP', '00:04:16');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (131, 9, 7, null, '10AM/ Save the World (feat.  Gucci Mane)', '00:03:46');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (132, 9, 7, null, 'OverDue (feat. Travis Scott)', '00:02:46');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (133, 9, 7, null, 'Don''t Come Out the House (feat. 21 Savage)', '00:02:48');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (134, 9, 7, null, 'Dreamcatcher (feat. Swae Lee & Travis Scott)', '00:03:31');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (135, 9, 7, null, 'Space Cadet', '00:03:23');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (136, 9, 7, null, '10 Freaky Girls (feat. 21 Savage)', '00:03:28');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (137, 9, 7, null, 'Up to Something (feat. Travis Scott & Young Thug)', '00:03:04');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (138, 9, 7, null, 'Only 1 (Interlude) [feat. Travis Scott]', '00:01:20');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (139, 9, 7, null, 'Lesbian (feat. Gunna & Travis Scott)', '00:03:26');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (140, 9, 7, null, 'Borrowed Love (feat. Swae Lee & Wizkid)', '00:03:50');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (141, 9, 7, null, 'No More (feat. Travis Scott, Kodak Black, & 21 Savage)', '00:04:25');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (142, 9, 7, null, 'No Complaints', '00:04:25');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (143, 5, 7, null, 'Broken Whiskey Glass', '00:03:54');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (144, 5, 7, null, 'Deja Vu (feat. Justin Bieber)', '00:03:54');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (145, 5, 7, null, 'White Iverson', '00:04:17');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (146, 5, 7, null, 'I fall Apart', '00:03:43');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (147, 5, 7, null, 'Go Flex', '00:03:00');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (148, 5, 7, null, 'Feel (feat. Kehlani)', '00:03:17');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (149, 5, 7, null, 'Congratulations (feat. Quavo)', '00:03:40');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (150, 5, 7, null, 'Up There', '00:03:15');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (151, 5, 7, null, 'Leave', '00:05:25');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (152, 5, 7, null, 'Hit This Hard', '00:04:09');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (153, 5, 7, null, 'Money Made Me Do It (feat. 2 Chainz)', '00:03:45');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (154, 5, 7, null, 'Feeling Whitney', '00:04:17');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (155, 4, 7, null, 'Intro', '00:01:47');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (156, 4, 7, null, 'KOD', '00:03:12');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (157, 4, 7, null, 'Photograph', '00:03:39');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (158, 4, 7, null, 'The Cut Off', '00:03:57');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (159, 4, 7, null, 'ATM', '00:03:37');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (160, 4, 7, null, 'Motiv8', '00:02:14');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (161, 4, 7, null, 'Kevin''s Heart', '00:03:20');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (162, 4, 7, null, 'BRACKETS', '00:05:16');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (163, 4, 7, null, 'Once an Addict (Interlude)', '00:03:18');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (164, 4, 7, null, 'Friends', '00:04:18');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (165, 4, 7, null, 'Window Pain (Outro)', '00:04:47');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (166, 4, 7, null, '1985', '00:03:10');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (167, 6, 7, null, 'All Day Long', '00:03:28');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (168, 6, 7, null, 'Do You Remember', '00:03:57');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (169, 6, 7, null, 'Eternal', '00:04:04');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (170, 6, 7, null, 'Hot Shower', '00:03:46');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (171, 6, 7, null, 'We Go High', '00:04:59');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (172, 6, 7, null, 'I Got You (Always and Forever)', '00:04:41');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (173, 6, 7, null, 'Photo Ops (Skit)', '00:01:14');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (174, 6, 7, null, 'Roo ', '00:02:52');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (175, 6, 7, null, 'The Big Day', '00:04:02');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (176, 6, 7, null, 'Let''s Go On The Run', '00:03:41');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (177, 6, 7, null, 'Handsome', '00:02:53');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (178, 6, 7, null, 'Big Fish', '00:03:07');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (179, 6, 7, null, 'Ballin Flossin', '00:02:50');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (180, 6, 7, null, '4 Quarters In The Black (Skit)', '00:02:14');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (181, 6, 7, null, '5 Year Plan', '00:04:18');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (182, 6, 7, null, 'Get A Bag', '00:03:21');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (183, 6, 7, null, 'Slide Around', '00:04:31');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (184, 6, 7, null, 'Sun Come Down', '00:03:35');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (185, 6, 7, null, 'Found A Good One (Single No More)', '00:04:18');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (186, 6, 7, null, 'Town On The Hill', '00:02:59');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (187, 6, 7, null, 'Our House (Skit)', '00:01:05');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (188, 6, 7, null, 'Zanies and Fools', '00:05:23');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (189, 8, 7, null, 'This Is America', '00:03:45');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (190, 13, 9, null, '...Ready For It?', '00:03:28');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (191, 13, 9, null, 'End Game', '00:04:04');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (192, 13, 9, null, 'I Did Something Bad', '00:03:58');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (193, 13, 9, null, 'Don''t Blame Me', '00:03:56');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (194, 13, 9, null, 'Delicate', '00:03:52');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (195, 13, 9, null, 'Look What You Made Me Do', '00:03:31');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (196, 13, 9, null, 'So It Goes...', '00:03:47');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (197, 13, 9, null, 'Gorgeous', '00:03:29');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (198, 13, 9, null, 'Getaway Car', '00:03:53');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (199, 13, 9, null, 'King Of My Heart', '00:03:34');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (200, 13, 9, null, 'Dancing With Our Hands Tied', '00:03:31');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (201, 13, 9, null, 'Dress', '00:03:50');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (202, 13, 9, null, 'This Is Why We Can''t Have Nice Things', '00:03:27');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (203, 13, 9, null, 'Call It What You Want', '00:03:23');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (204, 13, 9, null, 'New Year''s Day', '00:03:55');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (205, 13, 9, null, 'Welcome To New York', '00:03:32');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (206, 13, 9, null, 'Blank Space', '00:03:51');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (207, 13, 9, null, 'Style', '00:03:51');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (208, 13, 9, null, 'Out Of The Woods', '00:03:55');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (209, 13, 9, null, 'All You Had To Do Was stay', '00:03:13');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (210, 13, 9, null, 'Shake It Off', '00:03:39');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (211, 13, 9, null, 'I Wish You Would', '00:03:27');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (212, 13, 9, null, 'Bad Blood', '00:03:31');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (213, 13, 9, null, 'Wildest Dreams', '00:03:40');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (214, 13, 9, null, 'How You Get The Girl', '00:04:07');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (215, 13, 9, null, 'This Love', '00:04:10');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (216, 13, 9, null, 'I Know Places', '00:03:15');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (217, 13, 9, null, 'Clean', '00:04:31');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (218, 10, 9, null, 'Easy', '00:03:16');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (219, 11, 10, null, 'Intro', '00:03:33');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (220, 11, 10, null, 'Bad Luck', '00:03:51');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (221, 11, 10, null, 'My Bad', '00:02:43');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (222, 11, 10, null, 'Better', '00:03:49');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (223, 11, 10, null, 'Talk', '00:03:17');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (224, 11, 10, null, 'Right Back', '00:03:35');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (225, 11, 10, null, 'Don''t Pretend (feat. SAFE)', '00:02:45');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (226, 11, 10, null, 'Paradise', '00:02:54');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (227, 11, 10, null, 'Hundred', '00:04:37');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (228, 11, 10, null, 'Outta My Head (feat. John Mayer)', '00:02:57');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (229, 11, 10, null, 'Free Spirit', '00:03:02');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (230, 11, 10, null, 'Twenty One', '00:03:04');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (231, 11, 10, null, 'Bluffin''', '00:03:19');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (232, 11, 10, null, 'Self', '00:03:49');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (233, 11, 10, null, 'Alive', '00:02:57');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (234, 11, 10, null, 'Heaven', '00:03:33');
INSERT INTO Song (song_id, artist_id, genre_id, lyrics, song_name, length) VALUES (235, 11, 10, null, 'Saturday Night', '00:03:31');

INSERT INTO Concert (concert_id, city, venue, country, year, state) VALUES (1, 'Tilburg', null, 'Netherlands', 2008, null);
INSERT INTO Concert (concert_id, city, venue, country, year, state) VALUES (2, 'Houston', 'NRG Park', 'USA', 2019, 'TX');
INSERT INTO Concert (concert_id, city, venue, country, year, state) VALUES (3, 'Folsom', 'Folsom State Prison', 'USA', 1968, 'CA');
INSERT INTO Concert (concert_id, city, venue, country, year, state) VALUES (4, 'Portland', 'Moda Center', 'USA', 2019, 'OR');
INSERT INTO Concert (concert_id, city, venue, country, year, state) VALUES (12, 'Minneapolis', 'US Bank', 'USA', 2018, 'MN');

INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (1, 1, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (2, 2, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (3, 3, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (4, 4, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (5, 5, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (6, 6, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (7, 7, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (8, 8, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (9, 9, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (10, 10, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (11, 11, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (12, 12, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (13, 13, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (14, 14, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (15, 15, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (16, 16, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (17, 17, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (18, 18, 1);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (19, 19, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (20, 20, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (21, 95, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (22, 32, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (23, 24, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (24, 108, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (25, 109, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (26, 80, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (27, 26, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (28, 25, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (29, 28, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (30, 98, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (31, 102, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (32, 110, 2);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (33, 63, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (34, 64, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (35, 65, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (36, 66, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (37, 67, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (38, 68, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (39, 69, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (40, 70, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (41, 71, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (42, 71, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (43, 73, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (44, 74, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (45, 75, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (46, 76, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (47, 77, 3);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (48, 190, 12);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (49, 192, 12);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (50, 197, 12);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (51, 195, 12);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (52, 191, 12);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (53, 199, 12);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (54, 194, 12);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (55, 210, 12);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (56, 206, 12);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (57, 212, 12);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (58, 50, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (59, 48, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (60, 51, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (61, 234, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (62, 233, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (63, 226, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (64, 232, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (65, 223, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (66, 228, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (67, 49, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (68, 219, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (69, 60, 4);
INSERT INTO Song_concert (song_concert_id, song_id, concert_id) VALUES (70, 235, 4);

INSERT INTO Playlist (playlist_id, playlist_name) VALUES (1, 'Even Songs Anesthetize');
INSERT INTO Playlist (playlist_id, playlist_name) VALUES (2, 'Stone''s Playlist');
INSERT INTO Playlist (playlist_id, playlist_name) VALUES (3, 'Annabel''s Playlist');
INSERT INTO Playlist (playlist_id, playlist_name) VALUES (4, 'Best of Travis Scott');
INSERT INTO Playlist (playlist_id, playlist_name) VALUES (5, 'Best of Mac Miller');

INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (1, 2, 1);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (2, 4, 1);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (3, 6, 1);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (4, 8, 1);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (5, 10, 1);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (6, 12, 1);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (7, 14, 1);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (8, 16, 1);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (9, 18, 1);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (10, 19, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (11, 21, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (12, 26, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (13, 27, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (14, 29, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (15, 35, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (16, 38, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (17, 39, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (18, 49, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (19, 50, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (20, 52, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (21, 12, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (22, 2, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (23, 73, 2);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (24, 44, 3);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (25, 46, 3);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (26, 47, 3);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (27, 49, 3);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (28, 50, 3);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (29, 156, 3);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (30, 51, 3);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (31, 19, 3);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (32, 46, 3);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (33, 37, 3);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (34, 25, 4);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (35, 31, 4);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (36, 91, 4);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (37, 102, 4);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (38, 23, 4);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (39, 19, 4);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (40, 85, 4);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (41, 81, 4);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (42, 34, 4);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (43, 110, 4);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (44, 35, 5);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (45, 36, 5);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (46, 37, 5);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (47, 38, 5);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (48, 39, 5);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (49, 40, 5);
INSERT INTO Song_playlist (song_playlist_id, song_id, playlist_id) VALUES (50, 41, 5);

INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (1, 1, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (2, 2, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (3, 3, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (4, 4, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (5, 5, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (6, 6, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (7, 7, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (8, 8, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (9, 9, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (10, 10, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (11, 11, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (12, 12, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (13, 13, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (14, 14, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (15, 15, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (16, 16, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (17, 17, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (18, 18, 1);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (20, 19, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (21, 20, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (22, 21, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (23, 22, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (24, 23, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (25, 24, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (26, 25, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (27, 26, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (28, 27, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (29, 28, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (30, 29, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (31, 30, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (32, 31, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (33, 32, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (34, 33, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (35, 34, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (36, 35, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (37, 36, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (38, 37, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (39, 38, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (40, 39, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (41, 40, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (42, 41, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (43, 42, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (44, 43, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (45, 44, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (46, 45, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (47, 46, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (48, 47, 3);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (49, 48, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (50, 49, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (51, 50, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (52, 51, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (53, 52, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (54, 53, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (55, 54, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (56, 55, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (57, 56, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (58, 57, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (59, 58, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (60, 59, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (61, 60, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (62, 61, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (63, 62, 5);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (64, 63, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (65, 64, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (66, 65, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (67, 66, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (68, 67, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (69, 68, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (70, 69, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (71, 70, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (72, 71, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (73, 72, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (74, 73, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (75, 74, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (76, 75, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (77, 76, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (78, 77, 4);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (79, 78, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (80, 79, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (81, 80, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (82, 81, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (83, 82, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (84, 83, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (85, 84, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (86, 85, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (87, 86, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (88, 87, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (89, 88, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (90, 89, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (91, 90, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (92, 91, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (93, 92, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (94, 93, 6);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (95, 94, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (96, 95, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (97, 96, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (98, 97, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (99, 98, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (100, 99, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (101, 100, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (102, 101, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (103, 102, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (104, 103, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (105, 104, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (106, 105, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (107, 106, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (108, 107, 7);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (109, 108, 8);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (110, 109, 9);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (111, 110, 2);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (112, 111, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (113, 112, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (114, 113, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (115, 114, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (116, 115, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (117, 116, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (118, 117, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (119, 118, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (120, 119, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (121, 120, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (122, 121, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (123, 122, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (124, 123, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (125, 124, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (126, 125, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (127, 126, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (128, 127, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (129, 128, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (130, 129, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (131, 130, 10);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (132, 131, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (133, 132, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (134, 133, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (135, 134, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (136, 135, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (137, 136, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (138, 137, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (139, 138, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (140, 139, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (141, 140, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (142, 141, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (143, 142, 11);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (144, 143, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (145, 144, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (146, 145, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (147, 146, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (148, 147, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (149, 148, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (150, 149, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (151, 150, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (152, 151, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (153, 152, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (154, 153, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (155, 154, 12);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (156, 155, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (157, 156, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (158, 157, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (159, 158, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (160, 159, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (161, 160, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (162, 161, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (163, 162, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (164, 163, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (165, 164, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (166, 165, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (167, 166, 13);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (168, 167, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (169, 168, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (170, 169, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (171, 170, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (172, 171, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (173, 172, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (174, 173, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (175, 174, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (176, 175, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (177, 176, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (178, 177, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (179, 178, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (180, 179, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (181, 180, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (182, 181, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (183, 182, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (184, 183, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (185, 184, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (186, 185, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (187, 186, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (188, 187, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (189, 188, 14);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (190, 189, 15);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (191, 190, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (192, 191, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (193, 192, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (194, 193, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (195, 194, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (196, 195, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (197, 196, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (198, 197, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (199, 198, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (200, 199, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (201, 200, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (202, 201, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (203, 202, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (204, 203, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (205, 204, 16);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (206, 205, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (207, 206, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (208, 207, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (209, 208, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (210, 209, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (211, 210, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (212, 211, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (213, 212, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (214, 213, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (215, 214, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (216, 215, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (217, 216, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (218, 217, 17);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (219, 218, 18);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (220, 219, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (221, 220, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (222, 221, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (223, 222, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (224, 223, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (225, 224, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (226, 225, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (227, 226, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (228, 227, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (229, 228, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (230, 229, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (231, 230, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (232, 231, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (233, 232, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (234, 233, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (235, 234, 19);
INSERT INTO Song_album (song_album_id, song_id, album_id) VALUES (236, 235, 19);

INSERT INTO Artist_concert (artist_concert_id, artist_id, concert_id) VALUES (1, 1, 1);
INSERT INTO Artist_concert (artist_concert_id, artist_id, concert_id) VALUES (2, 2, 2);
INSERT INTO Artist_concert (artist_concert_id, artist_id, concert_id) VALUES (3, 12, 3);
INSERT INTO Artist_concert (artist_concert_id, artist_id, concert_id) VALUES (4, 13, 12);
INSERT INTO Artist_concert (artist_concert_id, artist_id, concert_id) VALUES (5, 11, 4);

INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (1, 1, 1);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (2, 2, 2);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (3, 3, 3);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (5, 2, 6);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (6, 2, 7);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (7, 2, 8);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (8, 2, 9);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (9, 7, 10);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (10, 9, 11);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (11, 5, 12);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (12, 4, 13);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (13, 6, 14);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (14, 8, 15);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (15, 13, 16);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (16, 13, 17);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (17, 10, 18);
INSERT INTO Artist_album (artist_album_id, artist_id, album_id) VALUES (18, 11, 19);
