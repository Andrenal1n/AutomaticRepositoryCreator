   M S B A M L   `   `   `  ����U  QAutomaticRepositoryCreator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:AutomaticRepositoryCreatorAutomaticRepositoryCreator  5   	   e7clr-namespace:AutomaticRepositoryCreator.MVVM.ViewModel)AutomaticRepositoryCreator.MVVM.ViewModel  5   	   +    %AutomaticRepositoryCreator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:AutomaticRepositoryCreator     5   	   M	viewModel7clr-namespace:AutomaticRepositoryCreator.MVVM.ViewModel     5   	   -   5          � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   $	��600��5   	   $	��800��6    � DataContext 5      =  7AutomaticRepositoryCreator.MVVM.ViewModel.MainViewModel  5   
   .��5      ��  �� CornerRadius$ 5��6   $��2q�5      ���#dfe6e9��5   
   �� 5       �� ImageSource$ /Images/background.jpg��6   ._�5      �� $ 5��6   ��5      �� 5       �� 
StartPoint$ 0,1.3&�6&    �� EndPoint$	 1,3&�69   	 �� Opacity$
	 0.95Q�6H   .��5      � 
 � Color$
 #2d3436��6#    � Offset$ 0Q�63   � 5      $
 #636e72��6#   $	 0.5Q�63   5       ._�5#   
   �� $��
0,25,25,50q�6   $ 5��5$      ._�5&      �  � ColumnDefinitions 5'      �� 5(      $	��200 �6'   �� 5)       � RowDefinitions 5,      �� 5-      $��30 �6$   �� 5.      .+�51      �� $��0��6   $��0��52      $	��ARC��53      ���#00cec9$��28(�55      $
��Bold"�56      $��center=�57      $
��Left=�58      $��35,0,0,0q�59      �� 5;      $��1��6   $��0��5<       �� Orientation$ 
Horizontal=�5=      $��Right=�5>      $��Center=�5?      .+�5A      �� -   5         ��Name$ ButtonMinimize��5A       � Cursor$
 Hand��5B      $��0,0,15,0q�5D         WindowButtonTheme#��[  5E      ��5C      �� *MinimizeCommand+��5F      �� 5G   "   $��\Images\minimize-icon.png��6(   $��25��5H   ,   $��25��5I   ,   5L      �� 5N      -   5        $ ButtonClose��5N      $
 Hand��5O      $��0,0,0,0q�5Q      #��[  5R      ��5P      �� *CloseCommand+��5S      �� 5T   "   $#��\Images\close-square-icon.png��6(   $��25��5U   ,   $��25��5V   ,   5Y      5[      �� 5]      $��0��6   $��1��5^      $	��Top=�5_      $	��470��5`      $��0,20,0,0q�5a      .+�5c      	� -   5         	�Name$ btnHome��5c   &   $
 Hand��5d   &   $��20(�5e   &   $��70��5f   &     MenuButtonTheme#��[ 5g   &    d� 	IsChecked$
 TrueY�5h   &   ��5i   &   �� *HomeViewCommand+��5j      �� 5k   "   $ 
Horizontal=�6-   .+�5l   &   �� $��\Images\home-icon.png��6,   $��20��5m   ,   $��20��5n   ,   $��0,0,10,0q�5o   ,   �� 5p   &   $
��Home��60   5q   #   5s      	� 5u      -   5        $ 
btnNewRepo��5u   &   $
 Hand��5v   &   $��20(�5w   &   $��70��5x   &   #��[ 5y   &   ��5z   &   �� *NewRepoCommand+��5{      �� 5|   "   $ 
Horizontal=�6-   .+�5}   &   �� $"��\Images\plus-square-icon.png��6,   $��20��5~   ,   $��20��5   ,   $��0,0,10,0q�5�   ,   �� 5�   &   $��New Project��60   5�   #   5�      	� 5�      -   5        $ btnHelp��5�   &   $
 Hand��5�   &   $��20(�5�   &   $��70��5�   &   #��[ 5�   &   ��5�   &   �� *HelpCommand+��5�      �� 5�   "   $ 
Horizontal=�6-   .+�5�   &   �� $/��)\Images\question-mark-round-line-icon.png��6,   $��20��5�   ,   $��20��5�   ,   $��0,0,10,0q�5�   ,   �� 5�   &   $
��Help��60   5�   #   5�      �� 5�      	 �� X1$ 25��6   	 �� Y1$ 0��6'   	 �� X2$	 175��6.   	 �� Y2$ 0��67   ���#dfe6e9$��3��5�      $��0,25,0,0q�5�      �� 5�      $ 
Horizontal=�6%   $��Center=�5�   %   $	��150��5�   %   $��0,25,0,0q�5�   %   .+�5�      �� -   5        $ ButtonGithub��5�   %   
������ $��0q�5�   %   $��45��5�   %   $��45��5�   %   $��20,0,0,0q�5�   %   $
 Hand��5�   %     MediaButtonTheme#��[ 5�   %   ��5�   %   �� *GithubLinkCommand+��5�   "   �� 5�   &   $��\Images\github-icon.png��6,   $��40��5�   (   $��40��5�   (   $��Center=�5�   (   $��Center=�5�   (   5�      �� 5�      -   5        $ ButtonDiscord��5�   %   
������ $��0q�5�   %   $��30,0,0,0q�5�   %   $��45��5�   %   $��45��5�   %   $
 Hand��5�   %   #��[ 5�   %   ��5�   %   �� *DiscordLinkCommand+��5�   "   �� 5�   &   $$��\Images\discord-round-icon.png��6,   $��40��5�   (   $��40��5�   (   $��Center=�5�   (   $��Center=�5�   (   5�      5�      �� 5�      ���#dfe6e9 J� Opacity$	 0.5Q�5�   !   $ 5��5�   !   $	��150��5�   !   $	��150��5�   !   $��Center=�5�   !   $��Bottom=�5�   !   $��0,15,0,0q�5�   !   ._�5�      �� $��10q�6)   .+�5�   "   �� $
��Wrap=�6,   $��10(�5�   ,   ARC�� 5�   &   Version 1.0�� 5�   &   $"Copyright (C) [2023] [Andre Ehret]�� 5�   &   GEThis software is licensed under the GNU General Public License (GPL).�� 5�   &   0.See the accompanying file LICENSE for details.5�   #   5�      5�      5�      �� 5�      $��1��6%   $��1��5�   %   $��	20,20,0,0q�5�   %   ��5�   %   �� *CurrentView+5�      5�      5�      5�      5�      