# DesignPattern.Bridge
Repository name describes what we are going to do. Here I took the problems of publisher. What he/she do? He publish paper on various topic that could be book, could be question paper or anything else. Here I have used 5 branches you need to go though branch to get understand what is happening.

First of all checkout https://simpleprogrammer.com/design-patterns-simplified-the-bridge-pattern/ to get basic understanding over bridge design pattern and the follow those steps to dig inside the repository.

Step 1:
Lets start with initial problem branch. Here I have fixed the basic problems of that publisher. Here we done the job without using any abstraction. And checkout the todo. 
<code>#P1, Need to execute all the printing task in a loop</code>. To fix this problem we need to go with abstraction.

Step 2:
Jump to <code>IntroduceInterface-PrintInForLoop</code> here we go with abstraction to solve #P1 and do the printing operation inside a loop. So we reduce code duplication. And now another problem rises. Publisher need to use text formatting for some his customer.

Step 3:
Remember, we need to add different type of formatting for different customer and we doen the job inside <code>AddStringFormattingMachanismUglySolution</code>. Branch name described it's a ugly solution. Why? please go inside the models I hope you could realize. Here we have added various classes for various text formatting and what happened when that publisher print 100 types of item and customer looking for 5 types of text formating option? Can you imagine? We need to define minimum 500 classes. And our next goal is #P3, fix ugly class explosion.

Step 4:
Jump to <code>UseBridgeDesignPattern</code>. I have introduce <code>IFormatter</code> interface and implemented on several classes to generate its own formatting. Those classes will do the remaining job of formatting and publisher need to add specific formatter for their specific print. And if he did not pass any, it will use default one.

Thanks for checking it out, and like to get star if it make scense to you. Happy coding :)
