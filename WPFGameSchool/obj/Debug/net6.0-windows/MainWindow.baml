   M S B A M L   `   `   `  ����H  DWPFGameSchool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFGameSchoolWPFGameSchool  5   	       WPFGameSchool.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFGameSchool     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� -   5         ��Name$ Mainpicture��5
      $��/Images/Barbarian.jpg��6%   $��3��6D   $��-96,-15,-96,-19q�6X   $��4��6q    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.141Q�6$   �� 5      T� 5       T� Y$ -0.998Q�6)   5      5      �� 5   
   $��Username��6   
�������$
��Left=�66   $	��Top=�6Q   $��
45,110,0,0q�6i   $��1��6}   $��2��6�   �� 5   
   -   5         ��Name$
 user��5      $��1��6    $��1��60   $
��Left=�6=   $��	60,30,0,0q�6X   $	��Top=�6k   $	��120��6�   
������ 
�������$��25��6�   � 5   
   $��1��6   $��2��6   .+�5      G� -   5         G�Name$
 pass��5      $
��Left=�6(   $��
60,-30,0,0q�6C   $	��Top=�6W   $	��120��6o   
������ $��25��6�   �� 5      -   5         ��Name$ passwordLabel��5      $��Password��6+   
�������$
��Left=�6Q   $	��Top=�6l   $��
45,-56,0,0q�6�   5      �� 5   
   -   5         ��Name$ 
SaveButton��5      $
��Save��6%   $��2��64   $��2��6D   $
��Left=�6Q   $��	133,5,0,0q�6l   $	��Top=�6   
�������$��46��6�   $
��Bold"�6�   ��5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5       �  � Color$ Black��6#   � 5!      $ 	#FFCAB298��6#    � Offset$ 1Q�65   5"      5$      �� 5%   
   -   5        $ 
LoadButton��5%      $
��Load��6%   $��2��64   $��2��6D   $
��Left=�6Q   $��	211,5,0,0q�6l   $	��Top=�6   
�������$��46��6�   $
��Bold"�6�   ��5&      �� 5'      $	 0.5,1&�6&   $
 0.5,0&�67   .��5(      � $ Black��6#   � 5)      $ 	#FFCBB093��6#   $ 1Q�65   5*      5,      �� 5-   
   -   5        $ ClearButton��5-      $��Clear��6&   $��2��66   $��2��6F   $
��Left=�6S   $��
173,35,0,0q�6n   $	��Top=�6�   
�������$��46��6�   $
��Bold"�6�   ��5.      �� 5/      $	 0.5,1&�6&   $
 0.5,0&�67   .��50      � $ Black��6#   � 51      $ 	#FFC1AE90��6#   $ 1Q�65   52      54      �� 55   
   -   5        $ Login��55      $��1��6    $��2��60   $��Login��6=   $
��Left=�6M   $��	45,80,0,0q�6h   $	��Top=�6{   
�������$��75��6�   $
��Bold"�6�   ��56      �� 57      $	 0.5,1&�6&   $
 0.5,0&�67   .��58      � $ Black��6#   � 59      $ 	#FFCEB695��6#   $ 1Q�65   5:      5<      �� 5=   
   -	   5        $ Register��5=      $��1��6#   $��2��63   $��Register��6@   $
��Left=�6S   $��
133,80,0,0q�6n   $	��Top=�6�   
�������$��75��6�   $
��Bold"�6�   ��5>      �� 5?      $	 0.5,1&�6&   $
 0.5,0&�67   .��5@      � $ Black��6#   � 5A      $ 	#FFCAB497��6#   $ 1Q�65   5B      5D      �� 5E   
   -
   5         ��Name$ userListBox��5E      $��2��6'   $��0��67   $��2��6D   $��134,10,10,0q�6U   
������ 
�������$��1q�6�   ��5F      �� 5G      .R�5H      ��  �� Orientation$ 
Horizontal=�6!   .+�5I      �� 
���������6$   �� *
Username+6>   5J      5K      5M       � ColumnDefinitions 5O   
   �� 5P      $��* �6   �� 5Q      $��* �6   �� 5R      $��* �6    � RowDefinitions 5U   
   �� 5V      $��* �6   �� 5W      $��* �6   �� 5X      $��* �6   �� 5Y      $��* �6   5\      5]      