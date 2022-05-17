# Study Prompts 

1. Run your Console application, what is it doing? What is being outputted to the console?
   
  The application displays outputs of two classes: DodgyBankAccount and SecureBankAccount. The outputs are the current account balances and their total balances after a   deposit and a reward.

2. Look at the DodgyBankAccount, this class is not well-encapsulated. Can you note down the problems with how the class is designed, and the ways it is being misused?

  In the DodgyBankAccount, attributes and methods have public access. As such, the program 
  is able to add inifinite number of rewards and even change the account balance.
  
3. Compare and contrast the DodgyBankAccount and the SecureBankAccount, how is the SecureBankAccount different to the DodgyBankAccount? How is it designed to prevent it from being misused? Are there instances of better method names for clearer abstraction?

  The SecureBankAccount class have private attributes and a private AddReward method. More specifically, the account number is a readonly access, and the reward amount     was set as a constant variable. 
      
