   M S B A M L   `   `   `  ����K  GHCI_Kviz_Gradovi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HCI_Kviz_GradoviHCI_Kviz_Gradovi  5   	   !    HCI_Kviz_Gradovi.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:HCI_Kviz_Gradovi     5   	     � Title$  Start��5   	   $	��420��6   $	��420��6$    � WindowStartupLocation$ CenterScreen=�60      CustomWindowStyle#��[  5	   	    � 	Resources 5
        RoundedButtonStyle1 �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Padding��%;  &	       �� 5   
   " ��6,   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5      $��2q�5      $ 20��5      $ 10q�6/   ._�5      �� $��Center=�6/   $��Center=�5      #��z��5      #��z��5      5      5      5      5      5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5       �� 5!      $��0* �6   .+�5$   
   �� $	��Top=�6   $��Center=�6-   $��0,70,0,0q�6J   $	��434��6\   
 J� RenderTransformOrigin$
 0.491,0.674&�6i   .+�5%      �� $"��Welcome to the Capital Quiz!��6   $��26(�6<   $��	Helvetica)�6J    �� TextAlignment$ Center=�6c   
���   �$
��Bold"�5&   +   $��Italic$�6=   �� 5(      $��Enter your username:��6   $��20(�64   $��60q�6B   $��Center=�6N   $��	Helvetica)�6k   �� 5)      -   5         ��Name$ UsernameTextBox��5)      $	��150��6/   $��20(�6;   $��	Helvetica)�6I   $��0, -70, 0, 0q�6a   $��30��6w   �� 5+      -   5        $��Start��5+   *   $��
Start Quiz��6   ���#86D293
���   �$��Oblique$�6c   $	��120��6w   $��60��6�   $��55q�6�   $��	Helvetica)�6�    � Cursor$
 Hand��6�   $��18(�6�   #��[ 6�   6�   5,      5.      5/      