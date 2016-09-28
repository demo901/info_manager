# info_manager
假设你创建好了一个项目，并切换到项目的根目录下面：
$ git status   //查看当前项目下所有文的状态，如果第一次，你会发现都红颜色的，因为它还没有交给git/github管理。
$ git add .   //（.）点表示当前目录下的所有内容，交给git管理，也就是提交到了git的本地仓库。
$ git commit –m ”new natter ”  //对你更新或修改了哪些内容做一个描述。
$ git remote add origin git@github.com:demo901/info_manager
//如果你是第一次提交项目，这一句非常重要，这是你本地的当前的项目与远程的哪个仓库建立连接。
Ps: origin可以改为别人的名字，但是在你下一次push（提交）时，也要用你修改之后的名字。
$ git remote -v  //查看你当前项目远程连接的是哪个仓库地址。
$ git push -u origin master  //将本地的项目提交到远程仓库中。
 ------------------------------------------------------------
如果你是第一次想把github上面的项目克隆到本地或者要克隆别人的项目到地。
$ git clone git@github.com:defnngj/hibernate-demo.git  //在git下面切换到想存放此项目的文件目录下，运行这条命令就可以将项目克隆下来。
假如本地已经存在了这个项目，而仓库中又有一新的更新，如何把更的合并到本地的项目中？
$ git fetch origin    //取得远程更新，这里可以看做是准备要取了
$ git merge origin/master  //把更新的内容合并到本地分支/master
------------------------------------------- 
项目中删除了一些文件，如何提交？
假如远程仓库中已经存了aaa这个文件，我fetch了下来，并删除了aaa这个文件，想再push上到远程仓库中，并使远程仓库中的项目被新的修改覆盖（也是是远程仓库中的aaa也被删除）
$ git status   //可以看到我们删除的哪些文件
$ git add .   //删除之后的文件提交git管理。
$ git rm   src/com/hzh/hibernate/dao/aaa.java    //移除我们删除的那个文件，不然git不允许我们往远程仓库提交。
Ps: 如果你想删除的是某个目录（java包），这里想移除整个目录的内容。
$ git rm  src/com/hzh/hibernate/bbb/ -r   // -r 会把bbb/目录下的所有内容一次性移动。
------------------------------------------------------------------------
远程创建了一个新仓库，本地创建了一个新项目，如何使新的项目与仓库对应起来？
$ git remote add origin git@github.com:demo901/info_manager
//还是这个命令，在你push项目之前加上这一句就OK了。
