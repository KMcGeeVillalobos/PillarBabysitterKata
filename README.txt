#Kristin’s BabySitterKata README

#To Run:
I have been running the solution in VisualStudio.

# Files Included
#PillarBabySitterKata
BabysitterInterface.cs - where you interact with the program.
Family.cs - defines the family object and creates the three families with times and rates.
Job.cs - creates the job object and includes the logic for payment of a job that spans 	different rate periods.
Program.cs - starts this party!
RatePeriod.cs - defines the different rules of the rate periods
TimeUtil.cs - handles the before/ after midnight issue 

#PillarBibySitterKataTests
 FamilyTest.cs - tests the family constructor to ensure that families include the necessary   elements
JobTest.cs - tests that the job is properly constructed and that jobs can span more than one rate period
RatePeriodTest.cs - tests several possible issues including incorrect input (ending before beginning), handling jobs that cross midnight, and the division of work hours into the appropriate rate periods

#Ambiguities
I handled the requirement that babysitters be paid for full hours only by routing up all rate periods to the full hour, thus if the babysitter works 4.25 hours s/he is paid for 5.