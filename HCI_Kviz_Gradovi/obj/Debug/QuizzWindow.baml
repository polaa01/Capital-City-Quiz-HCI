   M S B A M L   `   `   `  ����K  GHCI_Kviz_Gradovi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HCI_Kviz_GradoviHCI_Kviz_Gradovi  5   	   "    HCI_Kviz_Gradovi.QuizzWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:HCI_Kviz_Gradovi     5   	     � Title$  Quizz��5   	   $��	Helvetica)�6   $	��500��6.   $	��600��6;    � WindowStartupLocation$ CenterScreen=�6G      CustomWindowStyle#��[  6l    � 	Resources 5	        RoundedButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Padding��%;  &	       �� 5
   
   " ��6+   .�5   
   ��  � �� 5      �� 5      " ��6"   .R�5      �� #��z��6!   #��z��5   !   $��1q�5   !   $ 17��5   !   $ 10q�63   ._�5      �� $��Center=�6/   $��Center=�5      #��z��5      #��z��5      5      5      5      5      5      .��5      � $	�� 20q�6   .+�5   
   �� -   5        	 ��Name$	 QuestionText��5      $��24(�5       $
��Bold"�5!      
���   �$��Center=�5#      $	��Top=�5$      $��0, 60, 0, 0q�5%      �� 5&   
   -   5        $	 TimerTextBlock��5&      $��	Helvetica)�6,   $
��Left=�6D   $	��Top=�6_   $��16(�6w   $��8, 8, 10, 10q�6�   � 5'   
   -   5        $��QuizProgress��5'      $	��200��6*   $��20��66   
 � Minimum$
 0Q�6B    � Maximum$	 100Q�6N    � Value$ 0Q�6\   ���#8FD14F$	��Top=�6{   $��45, 8, 10, 10q�6�   �� 5*   
   $��Center=�6   $��Center=�60   $	��300��6M   $��0, 70, 0, 0q�6Y   .+�5+      �� -   5         ��Name$ AnswerButtonA��5+       � Cursor$
 Hand��6,   ���#86D293
���   �$��A��6f   $��18(�6r   $	��200��6�   $��50��6�   #��[ 6�   $��0,15,0,0q�6�   6�   �� 5,      -   5        $ AnswerButtonB��5,      #��[ 6,   $
 Hand��6X   ���#86D293
���   �$��B��6�   $��18(�6�   $	��200��6�   $��50��6�   $��0,15,0,0q�6�   6�   �� 5-      -   5        $ AnswerButtonC��5-      #��[ 6,   $
 Hand��6X   ���#86D293
���   �$��C��6�   $��18(�6�   $	��200��6�   $��50��6�   $��0,15,0,0q�6�   6�   �� 5.      -   5        $ AnswerButtonD��5.      #��[ 6,   $
 Hand��6X   ���#86D293
���   �$��D��6�   $��18(�6�   $	��200��6�   $��50��6�   $��0,15,0,0q�6�   6�   50      55      56      