/*
* Create and populate table Question
*/

IF OBJECT_ID('dbo.Question', 'U') IS NOT NULL
	DROP TABLE [dbo].[Question]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Question](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED ([ID] ASC)
) ON [PRIMARY]

GO


insert Question values('What is your name?', 1)
insert Question values('If You Were In A Band, What Kind Of Music Would You Play?', 2)
insert Question values('If You Had To Run Away From Everyone Then Where Would You Hide Yourself?', 3)
insert Question values('What Do You Think Is The Cleverest Animal And Why?', 4)
insert Question values('Which animal secretly knows exactly what it’s doing?', 5)
insert Question values('If You Had To Be One Cartoon Character, Which Would You Choose?', 6)
insert Question values('Would You Abandon Your Phone, Internet, Family, And Friends For Three Months For A Prize Of 1 Million Dollars?', 7)
insert Question values('What Is The Word You Absolutely Hate People For Using?', 8)
insert Question values('What Is The Most Beautiful Thing In Nature?', 9)
insert Question values('What Is Your Favorite Type Of Candy?', 10)
insert Question values('What makes your sweet tooth happiest?', 11)
insert Question values('How Do You Feel About Clowns?', 12)
insert Question values('What Are You Expecting From This Relationship?', 13)
insert Question values('Do Loud Noises Bother You?', 14)
insert Question values('What Have You Forgotten?', 15)
insert Question values('If You Had Two Hours Left On Earth What Would You Do?', 16)
insert Question values('Who Makes You Laugh More Than Anyone?', 17)
insert Question values('What’s The Best Gift You’ve Ever Given?', 18)
insert Question values('How Many Times A Day Do You Look In The Mirror?', 19)
insert Question values('If 100 People In Your Age Group Were Selected Randomly, How Many Do You Think They’d Find Leading A Happier Life Than You?', 20)
insert Question values('Where Do You Like To Go When You Eat Out?', 21)
insert Question values('Do You Like To Cook?', 22)
insert Question values('Could You Live Without The Internet?', 23)
insert Question values('Most Memorable Birthday?', 24)
insert Question values('What Would Your Perfect Day Be Like?', 25)
insert Question values('When Are You Happiest?', 26)
insert Question values('What’s On Your Bucket List?', 27)
insert Question values('Do You Have Any Trips Coming Up?', 28)
insert Question values('What’s Something You Could Teach Me About?', 29)
insert Question values('What Is Your Favorite Hobby?', 30)

-- select * from Question