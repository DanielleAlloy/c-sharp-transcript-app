   M S B A M L   `   `   `  ����F  BAssignment5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment5Assignment5  5   	       Assignment5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment5     5   	   -   5          � Title$)  #Transcript GUI v2 - Danielle Hyland��5   	   $	��450��65   $	��800��6B   .��5	      � .+�5
   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5        $
��Exit��5      6)   5      m� 5      $��Import��6   .@�5      m� -   5        $��Transcript from JSON...��5      6<   5      m� 5      $
��Help��6   .@�5      m� -   5        $��About...��5      6-   5      5      �� 5   
   -   5         ��Name$ TranscriptsListBox��5      $
��Left=�6.   $	��333��6I   $��	24,59,0,0q�6V   $	��Top=�6i   $	��271��6�   .@�5      ��  � DataContext 6   �� *Name+5      �� 5   
   $��Transcripts��6   $
��Left=�6&   $��	24,33,0,0q�6A   $	��Top=�6T   $	��133��6l   �� 5   
   $
��Name��6   $
��Left=�6   $��
358,83,0,0q�6:   $	��Top=�6N   $��74��6f   �� 5   
   -   5        $��NameTextBox��5   9   $
��Left=�6   $��23��6-   $��
464,87,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6u   $	��256��6�    � ToolTip$( "Selected Student Transcript's Name��6�    �� 
IsReadOnly .  6�   �� *Name+6�   �� 5   
   $��ID��6   $
��Left=�6   $��358,132,0,0q�68   $	��Top=�6M   $��74��6e   �� 5   
   -   5         ��Name$ 	IDTextBox��5   9   $
��Left=�6   $��23��6-   $��464,136,0,0q�6L   $
 Wrap=�6a   $	��Top=�6v   $	��256��6�   $&  Selected Student Transcript's ID��6�    .  6�   �� *Id+6�   �� 5   
   $��Major��6   $
��Left=�6    $��358,188,0,0q�6;   $	��Top=�6P   $��74��6h   �� 5   
   -   5        $ MajorTextBox��5   9   $
��Left=�6   $��23��6-   $��464,192,0,0q�6O   $
 Wrap=�6d   $	��Top=�6y   $	��256��6�   $) #Selected Student Transcript's Major��6�    .  6�   �� *Major+6�   5       5!      